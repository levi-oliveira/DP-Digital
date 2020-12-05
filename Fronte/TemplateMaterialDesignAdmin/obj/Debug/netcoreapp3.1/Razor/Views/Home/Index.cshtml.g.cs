#pragma checksum "C:\Users\l_san\Documents\GitHub\TemplateMaterialDesignAdmin\TemplateMaterialDesignAdmin\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a114c0b5e57132f0aff190eb80058bb464bd184"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\l_san\Documents\GitHub\TemplateMaterialDesignAdmin\TemplateMaterialDesignAdmin\Views\_ViewImports.cshtml"
using TemplateMaterialDesignAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\l_san\Documents\GitHub\TemplateMaterialDesignAdmin\TemplateMaterialDesignAdmin\Views\_ViewImports.cshtml"
using TemplateMaterialDesignAdmin.Models.Comum;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a114c0b5e57132f0aff190eb80058bb464bd184", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cea078a68d0e4f627aa3ad2b3558b32b4302846", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Widgets -->
<div class=""row clearfix"">
    <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box bg-pink hover-expand-effect"">
            <div class=""icon"">
                <i class=""material-icons"">playlist_add_check</i>
            </div>
            <div class=""content"">
                <div class=""text"">NOVAS TAREFAS</div>
                <div class=""number count-to"" data-from=""0"" data-to=""125"" data-speed=""15"" data-fresh-interval=""20""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box bg-cyan hover-expand-effect"">
            <div class=""icon"">
                <i class=""material-icons"">help</i>
            </div>
            <div class=""content"">
                <div class=""text"">NOVOS TICKETS</div>
                <div class=""number count-to"" data-from=""0"" data-to=""257"" data-speed=""1000"" data-fresh-interval=""20""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 c");
            WriteLiteral(@"ol-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box bg-light-green hover-expand-effect"">
            <div class=""icon"">
                <i class=""material-icons"">forum</i>
            </div>
            <div class=""content"">
                <div class=""text"">NOVOS COMENTÁRIOS</div>
                <div class=""number count-to"" data-from=""0"" data-to=""243"" data-speed=""1000"" data-fresh-interval=""20""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3 col-md-3 col-sm-6 col-xs-12"">
        <div class=""info-box bg-orange hover-expand-effect"">
            <div class=""icon"">
                <i class=""material-icons"">person_add</i>
            </div>
            <div class=""content"">
                <div class=""text"">NOVOS VISITANTES</div>
                <div class=""number count-to"" data-from=""0"" data-to=""1225"" data-speed=""1000"" data-fresh-interval=""20""></div>
            </div>
        </div>
    </div>
</div>
<!-- #END# Widgets -->

<!-- NÚMERO DE REQUISIÇÕES -->
<div class=""row clearf");
            WriteLiteral(@"ix"">
    <div class=""col-xs-12 col-sm-12 col-md-12 col-lg-12"">
        <div class=""card"">
            <div class=""header"">
                <div class=""row clearfix"">
                    <div class=""col-xs-12 col-sm-6"">
                        <h2>NÚMERO DE REQUISIÇÕES (%)</h2>
                    </div>
                    <div class=""col-xs-12 col-sm-6 align-right"">
                        <div class=""switch panel-switch-btn"">
                            <span class=""m-r-10 font-12"">TEMPO REAL</span>
                            <label>DESLIGADO<input type=""checkbox"" id=""realtime"" checked><span class=""lever switch-col-cyan""></span>LIGADO</label>
                        </div>
                    </div>
                </div>
                <ul class=""header-dropdown m-r--5"">
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class");
            WriteLiteral(@"=""material-icons"">more_vert</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li><a href=""javascript:void(0);"">AÇÃO</a></li>
                            <li><a href=""javascript:void(0);"">OUTRA AÇÃO</a></li>
                            <li><a href=""javascript:void(0);"">MAIS OUTRA AÇÃO</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""body"">
                <div id=""real_time_chart"" class=""dashboard-flot-chart""></div>
            </div>
        </div>
    </div>
</div>
<!-- #END# NÚMERO DE REQUISIÇÕES -->

<div class=""row clearfix"">
    <!-- VISITANTES -->
    <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
        <div class=""card"">
            <div class=""body bg-pink"">
                <div class=""sparkline"" data-type=""line"" data-spot-Radius=""4"" data-highlight-Spot-Color=""rgb(233, 30, 99)"" data-highlight-Line-Color=""#fff""
                     data-min-Sp");
            WriteLiteral(@"ot-Color=""rgb(255,255,255)"" data-max-Spot-Color=""rgb(255,255,255)"" data-spot-Color=""rgb(255,255,255)""
                     data-offset=""90"" data-width=""100%"" data-height=""92px"" data-line-Width=""2"" data-line-Color=""rgba(255,255,255,0.7)""
                     data-fill-Color=""rgba(0, 188, 212, 0)"">
                    12,10,9,6,5,6,10,5,7,5,12,13,7,12,11
                </div>
                <ul class=""dashboard-stat-list"">
                    <li>
                        HOJE
                        <span class=""pull-right""><b>1 200</b> <small>USUÁRIOS</small></span>
                    </li>
                    <li>
                        ONTEM
                        <span class=""pull-right""><b>3 872</b> <small>USUÁRIOS</small></span>
                    </li>
                    <li>
                        SEMANA PASSADA
                        <span class=""pull-right""><b>26 582</b> <small>USUÁRIOS</small></span>
                    </li>
                </ul>
            </div>
        </div>
    </div>");
            WriteLiteral(@"
    <!-- #END# VISITANTES -->

    <!-- ÚLTIMAS TENDÊNCIAS SOCIAIS -->
    <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
        <div class=""card"">
            <div class=""body bg-cyan"">
                <div class=""m-b--35 font-bold"">ÚLTIMAS TENDÊNCIAS SOCIAIS</div>
                <ul class=""dashboard-stat-list"">
                    <li>
                        #socialtrends
                        <span class=""pull-right"">
                            <i class=""material-icons"">trending_up</i>
                        </span>
                    </li>
                    <li>
                        #materialdesign
                        <span class=""pull-right"">
                            <i class=""material-icons"">trending_up</i>
                        </span>
                    </li>
                    <li>#adminbsb</li>
                    <li>#freeadmintemplate</li>
                    <li>#bootstraptemplate</li>
                    <li>
                        #freehtmltemplate
               ");
            WriteLiteral(@"         <span class=""pull-right"">
                            <i class=""material-icons"">trending_up</i>
                        </span>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <!-- #END# ÚLTIMAS TENDÊNCIAS SOCIAIS -->

    <!-- Answered Tickets -->
    <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
        <div class=""card"">
            <div class=""body bg-teal"">
                <div class=""font-bold m-b--35"">TICKETS RESPONDIDOS</div>
                <ul class=""dashboard-stat-list"">
                    <li>
                        HOJE
                        <span class=""pull-right""><b>12</b> <small>TICKETS</small></span>
                    </li>
                    <li>
                        ONTEM
                        <span class=""pull-right""><b>15</b> <small>TICKETS</small></span>
                    </li>
                    <li>
                        SEMANA PASSADA
                        <span class=""pull-right""><b>90</b> <small>TICK");
            WriteLiteral(@"ETS</small></span>
                    </li>
                    <li>
                        MÊS PASSADO
                        <span class=""pull-right""><b>342</b> <small>TICKETS</small></span>
                    </li>
                    <li>
                        ANO PASSADO
                        <span class=""pull-right""><b>4 225</b> <small>TICKETS</small></span>
                    </li>
                    <li>
                        TODOS
                        <span class=""pull-right""><b>8 752</b> <small>TICKETS</small></span>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <!-- #END# Answered Tickets -->
</div>

<div class=""row clearfix"">
    <!-- INFORMAÇÃO DE TAREFAS -->
    <div class=""col-xs-12 col-sm-12 col-md-8 col-lg-8"">
        <div class=""card"">
            <div class=""header"">
                <h2>INFORMAÇÃO DE TAREFAS</h2>
                <ul class=""header-dropdown m-r--5"">
                    <li class=""dropdown"">
                    ");
            WriteLiteral(@"    <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">more_vert</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li><a href=""javascript:void(0);"">AÇÃO</a></li>
                            <li><a href=""javascript:void(0);"">OUTRA AÇÃO</a></li>
                            <li><a href=""javascript:void(0);"">MAIS OUTRA AÇÃO</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""body"">
                <div class=""table-responsive"">
                    <table class=""table table-hover dashboard-task-infos"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>TAREFA</th>
                                <th>STATUS</th>
                           ");
            WriteLiteral(@"     <th>GERENTE</th>
                                <th>PROGRESSO</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>1</td>
                                <td>TAREFA A</td>
                                <td><span class=""label bg-green"">EM PROGRESSO</span></td>
                                <td>LUCAS SANTOS</td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-green"" role=""progressbar"" aria-valuenow=""62"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 62%""></div>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>2</td>
                                <td>TAREFA B</td>
                                <td><span class=""label bg-blue"">A FA");
            WriteLiteral(@"ZER</span></td>
                                <td>LUCAS SANTOS</td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-blue"" role=""progressbar"" aria-valuenow=""40"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 40%""></div>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>3</td>
                                <td>TAREFA C</td>
                                <td><span class=""label bg-light-blue"">EM ESPERA</span></td>
                                <td>LUCAS SANTOS</td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-light-blue"" role=""progressbar"" aria-valuenow=""72"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 72%""></div>
                 ");
            WriteLiteral(@"                   </div>
                                </td>
                            </tr>
                            <tr>
                                <td>4</td>
                                <td>TAREFA D</td>
                                <td><span class=""label bg-orange"">ESPERANDO APROVAÇÃO</span></td>
                                <td>LUCAS SANTOS</td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-orange"" role=""progressbar"" aria-valuenow=""95"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 95%""></div>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>5</td>
                                <td>TAREFA E</td>
                                <td>
                                    <span class=""label bg-red"">SUSPENDIDA</span>
               ");
            WriteLiteral(@"                 </td>
                                <td>LUCAS SANTOS</td>
                                <td>
                                    <div class=""progress"">
                                        <div class=""progress-bar bg-red"" role=""progressbar"" aria-valuenow=""87"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 87%""></div>
                                    </div>
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <!-- #END# INFORMAÇÃO DE TAREFAS -->

    <!-- BROWSER USADOS -->
    <div class=""col-xs-12 col-sm-12 col-md-4 col-lg-4"">
        <div class=""card"">
            <div class=""header"">
                <h2>BROWSER USADOS</h2>
                <ul class=""header-dropdown m-r--5"">
                    <li class=""dropdown"">
                        <a href=""javascript:void(0);"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""butt");
            WriteLiteral(@"on"" aria-haspopup=""true"" aria-expanded=""false"">
                            <i class=""material-icons"">more_vert</i>
                        </a>
                        <ul class=""dropdown-menu pull-right"">
                            <li><a href=""javascript:void(0);"">AÇÃO</a></li>
                            <li><a href=""javascript:void(0);"">OUTRA AÇÃO</a></li>
                            <li><a href=""javascript:void(0);"">MAIS OUTRA AÇÃO</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
            <div class=""body"">
                <div id=""donut_chart"" class=""dashboard-donut-chart""></div>
            </div>
        </div>
    </div>
    <!-- #END# BROWSER USADOS -->
</div>");
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
