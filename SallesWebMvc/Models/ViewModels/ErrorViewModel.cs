using System;

namespace SallesWebMvc.Models.ViewModels
{
    public class ErrorViewModel   

 //1º passo Criar a pasta ViewModels, em seguida arrastar o arquivo para a mesma e depois recompilar o projeto e corrigir os erros
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

}