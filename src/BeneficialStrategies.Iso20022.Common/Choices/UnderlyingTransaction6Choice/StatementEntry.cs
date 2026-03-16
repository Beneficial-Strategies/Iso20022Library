// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.UnderlyingTransaction6Choice
{
    /// <summary>
    /// Reference details on the underlying statement cash entry.
    /// </summary>
    [IsoId("_xLWglcloEem0vqvvoqYsqQ")]
    [DisplayName("Statement Entry")]
    [IsoXmlTag("StmtNtry")]
    public record StatementEntry : UnderlyingTransaction6Choice_
    {
        /// <summary>
        /// Set of elements used to provide information on the original message.
        /// </summary>
        [IsoId("_ebdM8c4zEeis464yZacv2g")]
        [DisplayName("Original Group Information")]
        [IsoXmlTag("OrgnlGrpInf")]
        public OriginalGroupInformation29? OriginalGroupInformation { get; init; }

        /// <summary>
        /// Unique identification, as assigned by the account servicer, to unambiguously identify the original statement.
        /// </summary>
        [IsoId("_ebdM884zEeis464yZacv2g")]
        [DisplayName("Original Statement Identification")]
        [IsoXmlTag("OrgnlStmtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? OriginalStatementIdentification { get; init; }

        /// <summary>
        /// Original unique identification, as assigned by the account servicer, to unambiguously identify the original entry.
        /// </summary>
        [IsoId("_ebdM9c4zEeis464yZacv2g")]
        [DisplayName("Original Entry Identification")]
        [IsoXmlTag("OrgnlNtryId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public IsoMax35Text? OriginalEntryIdentification { get; init; }

        /// <summary>
        /// Universally unique identifier to provide the original end-to-end reference of a payment transaction.
        /// </summary>
        [IsoId("_afVVoc4zEeis464yZacv2g")]
        [DisplayName("Original UETR")]
        [IsoXmlTag("OrgnlUETR")]
        [IsoSimpleType(IsoSimpleType.UUIDv4Identifier)]
        public IsoUUIDv4Identifier? OriginalUETR { get; init; }
    }
}
