using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebAppCoreImage.Models
{
    public class Image
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Extension { get; set; }
        public int Length { get; set; }
        public byte[] Picture { get; set; }
        public string ContentType { get; set; }
    }

    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.ToTable("Image");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id);                

            builder.Property(x => x.Description)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Extension)
                .HasMaxLength(4)
                .IsRequired();

            builder.Property(x => x.Length)
                .IsRequired();

            builder.Property(x => x.Picture);

            builder.Property(x => x.ContentType)
                .IsRequired()
                .HasMaxLength(20);
        }

        public static ImageMap Create() => new ImageMap();
    }
}
