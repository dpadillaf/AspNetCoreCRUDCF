using System;
using System.ComponentModel.DataAnnotations;

namespace SistemaWebCF.Models
{
	public class Producto
	{
		public int idproducto { get; set; }
		[Required(ErrorMessage = "Ingrese una categoría")]
		public int idcategoria { get; set; }
		[StringLength(64, ErrorMessage = "El código no debe tener más de 64 caracteres")]
		[Display(Name = "Código")]
		public string codigo { get; set; }
		[Required(ErrorMessage = "Ingrese un nombre para el producto")]
		[StringLength(100, ErrorMessage = "El nombre no debe tener más de 100 caracteres")]
		[Display(Name = "Nombre")]
		public string nombre { get; set; }
		[Required(ErrorMessage = "Ingrese un precio de venta")]
		[Display(Name = "Precio de venta")]
		public Decimal precio_venta { get; set; }
		[Required(ErrorMessage = "Ingrese el stock del producto")]
		[Display(Name = "Stock")]
		public int stock { get; set; }
		[StringLength(255, ErrorMessage = "La descripción no debe tener más de 255 caracteres")]
		[Display(Name = "Descripción")]
		public string descripcion { get; set; }
		[Display(Name = "Estado")]
		public bool? estado { get; set; }
		[Display(Name = "Categoría")]
		public virtual  Categoria categoria { get; set; }
	}
}
