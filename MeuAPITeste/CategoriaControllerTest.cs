using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using Microsoft.EntityFrameworkCore;
using Xunit;
using MeuAPI1.Controllers;

namespace MeuAPITeste
{
    public class CategoriaControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Categoria _categoria;
        public CategoriaControllerTest(){
            _mockSet = new Mock<DbSet<Categoria>>();


            _mockContext = new Mock<Context>();
            
            _categoria = new Categoria { Id = 1, descricao = "Teste Categoria" };

            _mockContext.Setup(m => m.Categorias).Returns(_mockSet.Object);

            _mockContext.Setup(m => m.Categorias.FindAsync(1)).ReturnsAsync(_categoria);




        
        }
            [Fact]

            public async Task Get_Categoria()
        {
            var service = new CategoriasController(_mockContext.Object);
            await service.GetCategoria(1);
            _mockSet.Verify( m => m.FindAsync(1),
                Times.Once());
        }
    
    }
}
