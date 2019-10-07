﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationTest.Default" %>

<%-- Страничная директива или директива Page --%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="Styles.css" />
</head>
<body>
    <form id="rsvpform" runat="server">
        <div>
            <h1>Новый год у Татьяны!</h1>
            <p>Мы устроим классную вечеринку и вы приглашены!</p>
        </div>
        <%-- ValidationSummary генерирует порцию html кода при проверке достоверности --%>
        <asp:ValidationSummary ID="validationSummary" runat="server" ShowModelStateErrors="true" />
        <div>
            <label>Ваше имя:</label><input type="text" id="name" runat="server" />
        </div>
        <div>
            <label>Ваш email:</label><input type="text" id="email" runat="server" />
        </div>
        <div>
            <label>Ваш телефон:</label><input type="text" id="phone" runat="server" />
        </div>
        <div>
            <label>Вы придете?</label>
            <select id="willattend" runat="server">
                <option value="">Выберите один из вариантов</option>
                <option value="true">Да</option>
                <option value="false">Нет</option>
            </select>
        </div>
        <div>
            <button type="submit">Отправить приглашение RSVP</button>
        </div>
        <asp:TextBox ID="txtInput" runat="server" />
        <asp:Button ID="btn" runat="server" Text="Button" OnClientClick="Click();" />
    </form>

    <script type="text/javascript">
        function Click() {
            var str = 'Hello, world!'
            alert(str);
        }
    </script>
</body>
</html>
