// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CashAssetType1Choice
{
    /// <summary>
    /// Type of cash expressed as a code.
    /// </summary>
    [IsoId("_1JOBIEyIEeir2sRRVd9XhA")]
    [DisplayName("Code")]
    public partial record Code : CashAssetType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a source of the cash asset.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CashAssetType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
