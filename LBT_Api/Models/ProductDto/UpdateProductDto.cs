﻿using System.ComponentModel.DataAnnotations;

namespace LBT_Api.Models.ProductDto
{
    public class UpdateProductDto
    {
        [Required]
        public int Id { get; set; }

        // Optional
        public int? SupplierId { get; set; }
        public string? Name { get; set; }
        public double? PriceNow { get; set; }
    }
}
