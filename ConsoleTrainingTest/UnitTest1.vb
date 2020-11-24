Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VbConsoleTraining
Imports Moq

<TestClass()> Public Class UnitTest1

    Private yesman As YesMan = Nothing

    <TestInitialize()> Public Sub TestInitialize()
        yesman = New YesMan()
    End Sub

    <TestMethod()> Public Sub TestMethod1()
        Assert.AreEqual(True, yesman.SayYes())
    End Sub

    <TestMethod(), TestCategory("カテゴリ1")> Public Sub TestMethod2()
        Dim mock As New Mock(Of ISome)()
        mock.Setup(Function(v) v.AnyDo()).Returns(False)
        Assert.AreEqual(False, mock.Object.AnyDo())
    End Sub

End Class