#pragma checksum "C:\Users\SDSD\source\repos\ffdcRetailBanking\Pages\Docs\code_grand.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab5d1671fcaf2da23f172f6a03f9b66d88608ffc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ffdcRetailBanking.Pages.Docs.Pages_Docs_code_grand), @"mvc.1.0.view", @"/Pages/Docs/code_grand.cshtml")]
namespace ffdcRetailBanking.Pages.Docs
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\SDSD\source\repos\ffdcRetailBanking\Pages\_ViewImports.cshtml"
using ffdcRetailBanking;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab5d1671fcaf2da23f172f6a03f9b66d88608ffc", @"/Pages/Docs/code_grand.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0549f64394f0cbed2fc994be4d07f85c03006b18", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Docs_code_grand : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("preview"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab5d1671fcaf2da23f172f6a03f9b66d88608ffc3438", async() => {
                WriteLiteral("\n\t<meta charset=\"utf-8\">\n\t<title>.md</title>\n\t<style></style>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ab5d1671fcaf2da23f172f6a03f9b66d88608ffc4469", async() => {
                WriteLiteral(@"

	<h4 class=""code-line"" data-line-start=0 data-line-end=1><a id=""How_it_works_0""></a>How it works</h4>
	<p class=""has-line-data"" data-line-start=""1"" data-line-end=""2"">In addition to exchanging the <code>client_id</code> and <code>client_secret</code> of your FusionCreator application for the access token, your client requires your user to authenticate with a username and a password. Once the access token is retrieved, when it expires, a new token is requested in the background, using the refresh token, as described in RFC6749.</p>
	<p class=""has-line-data"" data-line-start=""3"" data-line-end=""4"">To find out more about the Authorization Code Grant, see RFC6749, sections <a href=""https://tools.ietf.org/html/rfc6749#section-1.3.1"">1.3.1</a>, <a href=""https://tools.ietf.org/html/rfc6749#section-1.5"">1.5</a>, and <a href=""https://tools.ietf.org/html/rfc6749#section-4.1"">4.1</a>.</p>
	<p class=""has-line-data"" data-line-start=""5"" data-line-end=""6"">This sample is using the <code>IdentityModel.AspNetCore</code> specifi");
                WriteLiteral(@"c helper library for token management in <a href=""http://asp.net/"">ASP.NET Core</a> and the <code>Microsoft.Extensions.DependencyInjection.AddOpenIdConnect</code> library of the <a href=""https://www.nuget.org/packages/Microsoft.AspNetCore.Authentication.OpenIdConnect/3.1.2"">OpenIdConnect</a> package.</p>
	<hr>
	<h4 class=""code-line"" data-line-start=8 data-line-end=9><a id=""Application_configuration_8""></a>Application configuration</h4>
	<pre><code class=""has-line-data"" data-line-start=""10"" data-line-end=""26"">//application.Development.json
    &quot;Finastra&quot;: {
        &quot;Oauth2Configuration&quot;: {
        ...
        &quot;B2C&quot;: {
            &quot;ClientId&quot;: &quot;&lt;%YOUR-CLIENT-ID%&gt;&quot;,
            &quot;ClientSecret&quot;: &quot;&lt;%YOUR-SECRET-KEY%&gt;&quot;,
            &quot;JwkKeyId&quot;: &quot;&lt;PUBLIC_KEY_ID_REGISTERED_AT_FINASTRA&gt;&quot;,
            &quot;PrivateKey&quot;: &quot;./Keys/SampleKeys/private.der&quot;
        },
        &quot;ClientAuthenticationMetho");
                WriteLiteral(@"d&quot;: &quot;{client_secret | private_key_jwt}&quot;,
        ...
        }
        ...
    }
    </code></pre>
	<hr>
	<h5 class=""code-line"" data-line-start=27 data-line-end=28><a id=""Services_registration_27""></a>Services registration</h5>
	<pre><code class=""has-line-data"" data-line-start=""30"" data-line-end=""70"">//Startup.cs
    services.AddAuthentication(o =&gt;
        {
            o.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            o.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
        })
            .AddCookie()
            .AddOpenIdConnect(o =&gt;
            {
                o.ClientId = Oauth2Configuration.B2C.ClientId;
                o.ClientSecret = Oauth2Configuration.B2C.ClientSecret;
                o.Authority = Oauth2Configuration.AuthorityEndpoint;
                o.CallbackPath = &quot;/signin-oidc&quot;; // this path or your custom one should be registered in FFDC application configuration
                o.SaveTokens = true;
       ");
                WriteLiteral(@"         o.ResponseType = OpenIdConnectResponseType.Code;
                // Indicates a Query Response see: http://openid.net/specs/openid-connect-core-1_0.html#ImplicitAuthResponse.
                // other variant - form POST.
                o.ResponseMode = OpenIdConnectResponseMode.Query;
                o.Events.OnAuthorizationCodeReceived = context =&gt;
                {
                    if (Oauth2Configuration.ClientAuthenticationMethod ==
                        ClientAuthenticationMethod.client_secret)
                    {
                        return Task.CompletedTask;
                        //for client secret no need to set clientAssertion.
                    }

                    var tokenGenerator = context.HttpContext.RequestServices.GetService&lt;IPrivateKeyJwtGenerator&gt;();
                    context.TokenEndpointRequest.ClientAssertionType = OidcConstants.ClientAssertionTypes.JwtBearer;
                    context.TokenEndpointRequest.ClientAssertion = tokenGenerator.CreateCl");
                WriteLiteral(@"ientAuthJwt(new PrivateKeyJwtOptions
                    {
                        ClientId = Oauth2Configuration.B2C.ClientId,
                        JwkKeyId = Oauth2Configuration.B2B.JwkKeyId,
                        PrivateKeyPath = Oauth2Configuration.B2B.PrivateKey
                    //other params if they are different in config
                });
                    return Task.CompletedTask;
                };
            });
    </code></pre>
	<hr>
	<h4 class=""code-line"" data-line-start=72 data-line-end=73><a id=""Highlights_72""></a>Highlights</h4>
	<p class=""has-line-data"" data-line-start=""74"" data-line-end=""75"">Token retrieval is transparent for API user. Delegating <code>ClientAccessTokenHandler</code> handler attached via <code>.AddClientAccessTokenHandler()</code> authenticates client and retrieves access token.</p>
	<p class=""has-line-data"" data-line-start=""76"" data-line-end=""77"">The authentication method is controlled via attaching custom event handler <code>OnAuthorizationCodeReceived</cod");
                WriteLiteral("e> and by adding token request parameters <code>ClientAssertionType</code> and <code>ClientAssertion</code>.</p>\n\n\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591