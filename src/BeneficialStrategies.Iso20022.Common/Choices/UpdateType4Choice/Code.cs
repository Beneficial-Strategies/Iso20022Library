// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UpdateType4Choice
{
    /// <summary>
    /// Update type expressed in coded form.
    /// </summary>
    [IsoId("_m_7dc_NBEeCuA5Tr22BnwA_238148282")]
    [DisplayName("Code")]
    public partial record Code : UpdateType4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the nature of a statement update, for example, it is a complete statement.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required StatementUpdateType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
