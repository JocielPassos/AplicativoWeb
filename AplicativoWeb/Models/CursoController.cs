using AplicativoWeb.Models;
using Microsoft.AspNetCore.Mvc;
namespace AplicativoWeb;

public class CursoController:Controller{
public IActionResult Index (){

    //set
    Curso c1 = new Curso();

    c1.Descricao = "Primeiros Passos no ASP.NET Core";
    c1.TituloInterno = "Desenvolvedor C#";
    c1.TituloMarketing = "Crie Aplicativos Incríveis";
    
    //get
    ViewData["Curso"]= c1;

    ViewData ["desc"] = c1.Descricao; 
    ViewData ["titInt"] = c1.TituloInterno;
    ViewData ["titMark"] = c1.TituloMarketing;

    return View ();
}

//action
public IActionResult Create (){
    
    ViewData["titulo"]="Cadastro de Cursos";
    ViewBag.DataHora = DateTime.Now;
    return View();
}
}