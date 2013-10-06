using System.ComponentModel.DataAnnotations;

namespace HydroponicsDiary.Common.Types
{
    public class StrainImage
    {
        [Key]
        public int StrainImageId { get; set; }

        public byte[] Image { get; set; }

        /// <summary> Gets or sets the identifier of the strain. </summary>
        /// <value> The identifier of the strain. </value>
        public int StrainId { get; set; }

        /// <summary> Gets or sets the strain. </summary>
        /// <value> The strain. </value>
        public virtual Strain Strain { get; set; }
    }
}
