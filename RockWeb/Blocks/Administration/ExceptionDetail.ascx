﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ExceptionDetail.ascx.cs" Inherits="RockWeb.Blocks.Administration.ExceptionDetail" %>

<asp:UpdatePanel ID="upExcpetionDetail" runat="server">
    <ContentTemplate>
        <asp:Panel ID="pnlSummary" runat="server" Visible="false">
            
            <div class="banner"><h1><asp:Literal id="lPageTitle" runat="server"></asp:Literal></h1></div>

            <div class="row">
                <div class="col-md-6">
                    <div class="row">
                        <div class="col-md-2">
                            <!-- Site -->
                        </div>
                        <div class="col-md-10">
                            <Rock:RockLiteral Label="Site" ID="lblSite" runat="server" />
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-2">
                            Page
                        </div>
                        <div class="col-md-4">
                            <Rock:RockLiteral ID="lblPage" runat="server" />
                        </div>
                        <div class="col-md-6">
                            <asp:HyperLink ID="hlPageLink" runat="server" CssClass="btn btn-mini" Target="_blank"><i class="icon-arrow-right"></i></asp:HyperLink>
                        </div>
                    </div>
                </div>
                <div class="col-md-6">
                    <div class="col-md-2">User</div>
                    <div class="col-md-10">
                        <Rock:RockLiteral ID="lblUser" runat="server" />
                    </div>
                </div>
            </div>
            <div id="divQueryString" runat="server">
                Query String
                <div id="divQueryStringList">
                    <asp:Literal ID="litQueryStringList" runat="server" />
                </div>
            </div>
            <div class="row">
                <div class="col-md-2">
                    <Rock:RockCheckBox ID="cbShowCookies" runat="server" TextAlign="Right" />
                </div>
                <div class="col-md-2">
                    <Rock:RockCheckBox ID="cbShowServerVariables" runat="server" TextAlign="Left" />
                </div>
            </div>


            <div id="pnlCookies" style="display: none;">
                <fieldset>
                    <legend>Cookies</legend>
                    <asp:Literal ID="litCookies" runat="server" />
                </fieldset>
            </div>

            <div id="pnlServerVariables" style="display: none;">
                <fieldset>
                    <legend>Server Variables</legend>
                    <asp:Literal ID="litServerVariables" runat="server" />
                </fieldset>
            </div>
            <div id="pnlExceptionDetails">
                <fieldset>
                    <legend>Details</legend>
                    <asp:Table ID="tblExceptionDetails" runat="server" CssClass="table table-bordered table-striped table-hover">
                        <asp:TableHeaderRow ID="thRowExceptionDetails"  runat="server">
                            <asp:TableHeaderCell ID="thExceptionType" runat="server" Text="Exception Type" />
                            <asp:TableHeaderCell ID="thExceptionSource" runat="server" Text=" Source" />
                            <asp:TableHeaderCell ID="thExceptionDescription" runat="server" Text="Description" />
                            <asp:TableHeaderCell ID="thExceptionViewStackTrace" runat="server">&nbsp;</asp:TableHeaderCell>
                        </asp:TableHeaderRow>
                    </asp:Table>
                </fieldset>
            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>

<script type="text/javascript">
    function toggleStackTrace(exceptionId) {
        $("[id*=tdRowExceptionStackTrace_" + exceptionId + "]:first").toggleClass("exceptionDetail-stackTrace-hide");
        $("[id*=tdRowExceptionStackTrace_" + exceptionId + "]:first").toggleClass("exceptionDetail-stackTrace-show");

        if ($("[id*=tdRowExceptionStackTrace_" + exceptionId + "]:first").hasClass("exceptionDetail-stackTrace-hide")) {
            $("[id*=spanExceptionStackTrace_" + exceptionId + "]:first").html(" Show Stack Trace");
        }
        else {
            $("[id*=spanExceptionStackTrace_" + exceptionId + "]:first").html(" Hide Stack Trace");
        }
    }

    function redirectToPage(pageUrl) {
        if (pageUrl != undefined && pageUrl != "") {
            var host = document.location.protocol + "//" + document.location.hostname;
            if (document.location.port != 80 && document.location.port != 443) {
                host = host + ":" + document.location.port;
            }
            document.location.href = host + pageUrl;
        }
    }

    $("[id*=cbShowServerVariables]").click(function () {
        var cbSeverVariables = $(this);

        if (cbSeverVariables.is(":checked")) {
            $("#pnlServerVariables").css("display", "inherit");
        }
        else {
            $("#pnlServerVariables").css("display", "none");
        }
    });

    $("[id*=cbShowCookies]").click(function () {
        var cbCookies = $(this);

        if (cbCookies.is(":checked")) {
            $("#pnlCookies").css("display", "inherit");
        }
        else {
            $("#pnlCookies").css("display", "none");
        }
    });



</script>
