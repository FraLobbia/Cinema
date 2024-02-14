<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Cinema._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main >

             <form >
                      <div class="mb-3">
                            <label for="NameField" class="form-label">Nome</label>
                            <asp:TextBox ID="NameField" runat="server"></asp:TextBox>
     
                      </div>

                       <div class="mb-3">
                            <label for="SurnameField" class="form-label">Cognome</label>
                            <asp:TextBox ID="SurnameField" runat="server"></asp:TextBox>
                       </div>
  

                        <select id="SceltaSala" runat="server" class="form-select" aria-label="Default select example">
                              <option selected>Scegli la sala</option>
                              <option value="1">Sala Nord</option>
                              <option value="2">Sala Est</option>
                              <option value="3">Sala Sud</option>
                        </select>


                      <div class="my-3 form-check">
                        <asp:CheckBox  id="RidottoCheckbox" runat="server" />
                        <label class="form-check-label" for="RidottoCheckbox">Biglietto ridotto?</label>
                      </div>
            
                 <asp:Button type="submit" class="btn btn-primary" runat="server" Text="Compra Biglietto" OnClick="CompraBiglietto"/>
            </form>

    </main>
    
</asp:Content>
