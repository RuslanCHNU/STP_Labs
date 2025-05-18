<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConvertServices.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/WeightConverter.svc" />
                <asp:ServiceReference Path="~/CurrencyConverter.svc"  />
            </Services>
        </asp:ScriptManager>
        <asp:TextBox ID="inputValue" runat="server" Width="100" />
        <asp:Button 
            ID="convertBtn" 
            runat="server" 
            Text="Convert to kg" 
            OnClientClick="convert(); return false;" 
            UseSubmitBehavior="false" />
        <span id="result"></span>

        <br /><br />

        <asp:TextBox ID="txtUah" runat="server" Width="100" />
        <asp:Button
            ID="btnConvertCurrency"
            runat="server"
            Text="UAH → USD"
            OnClientClick="convertCurrency(); return false;"
            UseSubmitBehavior="false" />
        <span id="lblCurrencyResult"></span>

    </form>


<script type="text/javascript">
    function convertCurrency() {
        var uah = document.getElementById('<%= txtUah.ClientID %>').value;
      ConvertServices.ICurrencyConverter.ToUsd(
          uah,
          function (res) { document.getElementById('lblCurrencyResult').innerText = res; },
          function (err) { alert('Error currency: ' + err.get_message()); }
      );
      return false;
  }
    function convert() {
        var lbs = document.getElementById('<%= inputValue.ClientID %>').value;
        ConvertServices.IWeightConverter.ToKilograms(
            lbs,
            onSuccess,
            onError
        );
        return false;
    }
    function onSuccess(res) {
        document.getElementById('result').innerText = res;
    }
    function onError(err) {
        alert('Error: ' + err.get_message());
    }
</script>
</body>
</html>
