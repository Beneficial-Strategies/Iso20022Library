// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification41Choice
{
    /// <summary>
    /// Identification through a unique product identifier.
    /// </summary>
    [IsoId("_idD05Vo2Ee23K4GXSpBSeg")]
    [DisplayName("Unique Product Identifier")]
    public partial record UniqueProductIdentifier : SecurityIdentification41Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
