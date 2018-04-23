Imports Microsoft.VisualBasic
Imports System.Text.RegularExpressions
	Imports System
	Imports DevExpress.Xpo


<Persistent("Customers")> _
Public Class Customer
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    <Key()> _
    Public CustomerID As String

    Private _CompanyName As String
    Public Property CompanyName() As String
        Get
            Return _CompanyName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("CompanyName", _CompanyName, value)
        End Set
    End Property
    Private _ContactTitle As String
    Public Property ContactTitle() As String
        Get
            Return _ContactTitle
        End Get
        Set(ByVal value As String)
            SetPropertyValue("ContactTitle", _ContactTitle, value)
        End Set
    End Property

    <Association("CustomerOrders")> _
    Public ReadOnly Property Orders() As XPCollection(Of Order)
        Get
            Return GetCollection(Of Order)("Orders")
        End Get
    End Property
End Class

<Persistent("Orders")> _
Public Class Order
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub

    <Key()> _
    Public OrderID As Integer

    Private _Customer As Customer
    <Persistent("CustomerID"), Association("CustomerOrders")> _
    Public Property Customer() As Customer
        Get
            Return _Customer
        End Get
        Set(ByVal value As Customer)
            SetPropertyValue("Customer", _Customer, value)
        End Set
    End Property

    Private _Employee As Employee
    <Persistent("EmployeeID"), Association("EmployeeOrders")> _
    Public Property Employee() As Employee
        Get
            Return _Employee
        End Get
        Set(ByVal value As Employee)
            SetPropertyValue("Employee", _Employee, value)
        End Set
    End Property

    Private _OrderDate As DateTime
    Public Property OrderDate() As DateTime
        Get
            Return _OrderDate
        End Get
        Set(ByVal value As DateTime)
            SetPropertyValue("OrderDate", _OrderDate, value)
        End Set
    End Property

    Private _Freight As Decimal
    Public Property Freight() As Decimal
        Get
            Return _Freight
        End Get
        Set(ByVal value As Decimal)
            SetPropertyValue("Freight", _Freight, value)
        End Set
    End Property
End Class

<Persistent("Employees")> _
Public Class Employee
    Inherits XPLiteObject
    Public Sub New(ByVal session As Session)
        MyBase.New(session)
    End Sub
    <Key()> _
    Public EmployeeID As Integer

    Private _FirstName As String
    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("FirstName", _FirstName, value)
        End Set
    End Property

    Private _LastName As String
    Public Property LastName() As String
        Get
            Return _LastName
        End Get
        Set(ByVal value As String)
            SetPropertyValue("LastName", _LastName, value)
        End Set
    End Property

    <Association("EmployeeOrders")> _
    Public ReadOnly Property Orders() As XPCollection(Of Order)
        Get
            Return GetCollection(Of Order)("Orders")
        End Get
    End Property
End Class
