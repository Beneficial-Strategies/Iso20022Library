// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RepairStatus14Choice
{
    /// <summary>
    /// Specifies the reason of the repair status.
    /// </summary>
    [IsoId("_i5XwWTw5EeW3QqUkIQtIUA")]
    [DisplayName("Reason")]
    public partial record Reason : RepairStatus14Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("_ja_PoTw5EeW3QqUkIQtIUA")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RepairReason12Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_ja_PqTw5EeW3QqUkIQtIUA")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
