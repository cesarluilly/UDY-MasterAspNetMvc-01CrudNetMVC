using CrudNet8MVC.Datos;
using CrudNet8MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CrudNet8MVC.Controllers
{
    public class StudyInicioController : Controller
    {
        private readonly ApplicationDbContext _contexto;

        //--------------------------------------------------------------------------------------------------------------
        public StudyInicioController(
                                                            
                                                            //
           ApplicationDbContext contexto
           )
        {
            _contexto = contexto;
        }


        //public IActionResult Index(

        //    )
        //{
        //    return View(
        //        //                              
        //        this._contexto.Contacto.ToList()
        //        );
        //}
        public async Task<IActionResult> Index(
            //                                              //Nota. Tal parece que la aplicacion corre en un hilo
            //                                              //    llamado PRINCIPAL(A), y es lo que capta las solicitudes, 
            //                                              //    pero es aconsejable que ese hilo no se bloquee, 
            //                                              //    y para eso se utiliza el async para que el hilo
            //                                              //    principal no se bloquee y la aplicacion pueda
            //                                              //    captar otras solicitudes, entonces la consulta
            //                                              //    entonces la consulta esta corriendo en otro hilo(B)
            //                                              //    y cuando se termina de ejectutar, entonces el hilo
            //                                              //    principal continua su ejecucion despues de que si iso
            //                                              //    dicha consulta.
            //                                              //ENTONCES COMO CONCLUSION, EL HILO PRINCIPAL NUNCA DEBE
            //                                              //    DE BLOQUEARSE PARA QUE PUEDA CAPTAR OTRAS SOLICITUDES.
            //                                              //En caso de que el hilo principal llegara a bloquearse porque
            //                                              //    la operacion tardara mucho, pero si le llega otra
            //                                              //    peticion, por lo tanto la aplicacion no lo captaria
            //                                              //    y entonces ahi va a ver una solicitud perdida.
            )
        {
            return View(await this._contexto.Contacto.ToListAsync()
                );
        }

        //--------------------------------------------------------------------------------------------------------------
        [HttpGet]
        //                                                  //Este metodo solo sera para mostrar el formulario
        public IActionResult Crear()
        {
            return View();
        }

        //--------------------------------------------------------------------------------------------------------------
        [HttpPost]
        //                                                  //Validar token para que de esta manera podamos proternos de
        //                                                  //    ataques XSS.
        [ValidateAntiForgeryToken] 
        //                                                  //Este metodo solo sera para agregar el formulario
        public IActionResult Crear(Contacto contacto)
        {
            if (
                ModelState.IsValid
                )
            {
            }
            return View();
        }
    }
}
