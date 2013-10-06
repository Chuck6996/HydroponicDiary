// <copyright file="StrainLink.cs" company="MyCompany.com">
// Copyright (c) 2008 All Rights Reserved
// </copyright>
// <author>Chuck</author>
// <email>Chuck@MyCompany.com</email>
// <date>4/13/2013</date>
// <summary>Implements the strain link class</summary>

namespace HydroponicsDiary.Common.Types
{
    using System.ComponentModel.DataAnnotations;
    
    /// <summary> Interaction logic for StrainLink.cs.  </summary>
    public class StrainLink
    {
        /// <summary> Gets or sets the identifier of the link. </summary>
        /// <value> The identifier of the link. </value>
        [Key]
        public int StrainLinkId { get; set; }

        /// <summary> Gets or sets the link. </summary>
        /// <value> The link. </value>
        public string Link { get; set; }

        /// <summary> Gets or sets the identifier of the strain. </summary>
        /// <value> The identifier of the strain. </value>
        public int StrainId { get; set; }

        /// <summary> Gets or sets the strain. </summary>
        /// <value> The strain. </value>
        public virtual Strain Strain { get; set; }
    }
}
