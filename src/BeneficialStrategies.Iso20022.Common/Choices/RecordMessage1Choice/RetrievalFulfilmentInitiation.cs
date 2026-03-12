// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice
{
    /// <summary>
    /// Retrieval fulfilment initiation message record.
    /// </summary>
    [IsoId("_Ai2cQRs9EeqrvK3udMUsNQ")]
    [DisplayName("Retrieval Fulfilment Initiation")]
    public partial record RetrievalFulfilmentInitiation : RecordMessage1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Binary data of 2MB maximum.
        /// </summary>
        [IsoXmlTag("RtrvlFlfmtInitn")]
        [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
        public required IsoMax2MBBinary Value { get; init; } 
        
        
        #nullable disable
        
    }
}
