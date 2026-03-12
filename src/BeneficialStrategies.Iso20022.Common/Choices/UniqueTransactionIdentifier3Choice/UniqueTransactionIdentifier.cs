// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UniqueTransactionIdentifier3Choice
{
    /// <summary>
    /// Unique trade identifier (UTI) as agreed with the counterparty.
    /// </summary>
    [IsoId("__pAKwU7qEe2PGo0mhYCh1g")]
    [DisplayName("Unique Transaction Identifier")]
    public partial record UniqueTransactionIdentifier : UniqueTransactionIdentifier3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Unique Transaction Identifier (UTI). Unique number allocated to a financial transaction as agreed among the parties and/or within the regulatory system under which it is formed. The UTI is described in the latest edition of the international standard ISO 23897:2020.
        /// </summary>
        [IsoXmlTag("UnqTxIdr")]
        [IsoSimpleType(IsoSimpleType.UTIIdentifier)]
        public required IsoUTIIdentifier Value { get; init; } 
        
        
        #nullable disable
        
    }
}
