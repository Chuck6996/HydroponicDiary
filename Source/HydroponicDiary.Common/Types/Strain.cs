// ------------------------------------------------------------------------
// <copyright file="Strain.cs" company="NameOfCompany">
//     Copyright (c) 2013, NameOfCompany. All right reserved
// </copyright>
// ------------------------------------------------------------------------

namespace HydroponicsDiary.Common.Types
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Diagnostics.CodeAnalysis;

    /// <summary> Interaction logic for Strain.cs. </summary>
    public class Strain
    {
        /// <summary> Gets or sets the identifier of the strain. </summary>
        /// <value> The identifier of the strain. </value>
        [Key]
        public int StrainId { get; set; }

        /// <summary> Gets or sets the name. </summary>
        /// <value> The name. </value>
        [Required]
        [MaxLength(500)]
        public string Name { get; set; }

        /// <summary> Gets or sets the parent m. </summary>
        /// <value> The parent m. </value>
        [MaxLength(500)]
        public string ParentM { get; set; }

        /// <summary> Gets or sets the parent f. </summary>
        /// <value> The parent f. </value>
        [MaxLength(500)]
        public string ParentF { get; set; }

        /// <summary> Gets or sets the indica amount. </summary>
        /// <value> The indica. </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
        public int Indica { get; set; }

        /// <summary> Gets or sets the sativa. </summary>
        /// <value> The sativa. </value>
        public int Sativa { get; set; }

        /// <summary> Gets or sets the onset minimum. </summary>
        /// <value> The onset minimum. </value>
        public int OnsetMin { get; set; }

        /// <summary> Gets or sets the onset maximum. </summary>
        /// <value> The onset maximum. </value>
        public int OnsetMax { get; set; }

        /// <summary> Gets or sets the onset growth minimum. </summary>
        /// <value> The onset growth minimum. </value>
        public int OnsetGrowthMin { get; set; }

        /// <summary> Gets or sets the onset growth maximum. </summary>
        /// <value> The onset growth maximum. </value>
        public int OnsetGrowthMax { get; set; }

        /// <summary> Gets or sets the Tetrahydrocannabinol. </summary>
        /// <value> The Tetrahydrocannabinol. </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
        public decimal Thc { get; set; }

        /// <summary> Gets or sets the Cannabidiol level. </summary>
        /// <value> The Cannabidiol. </value>
        [SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1650:ElementDocumentationMustBeSpelledCorrectly", Justification = "Reviewed.")]
        public decimal Cbd { get; set; }

        /// <summary> Gets or sets the rating. </summary>
        /// <value> The rating. </value>
        public decimal Rating { get; set; }

        /// <summary> Gets or sets the appearance. </summary>
        /// <value> The appearance. </value>
        public string Appearance { get; set; }

        /// <summary> Gets or sets the aroma. </summary>
        /// <value> The aroma. </value>
        public string Aroma { get; set; }

        /// <summary> Gets or sets the flavor. </summary>
        /// <value> The flavor. </value>
        public string Flavor { get; set; }

        /// <summary> Gets or sets the description. </summary>
        /// <value> The description. </value>
        public string Description { get; set; }

        /// <summary> Gets or sets the modified timestamp. </summary>
        /// <value> The modified timestamp. </value>
        [Timestamp]
        public byte[] ModifiedTimestamp { get; set; }

        /// <summary> Gets or sets the time of the added date. </summary>
        /// <value> The time of the added date. </value>
        public DateTime AddedDateTime { get; set; }

        /// <summary> Gets or sets the strain links. </summary>
        /// <value> The strain links. </value>
        public virtual List<StrainLink> StrainLinks { get; set; }

        /// <summary> Gets or sets the strain images. </summary>
        /// <value> The strain images. </value>
        public virtual List<StrainImage> StrainImages { get; set; }
    }
}
