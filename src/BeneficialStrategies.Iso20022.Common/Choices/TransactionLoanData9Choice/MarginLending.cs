// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TransactionLoanData9Choice
{
    /// <summary>
    /// Details of the margin lending transaction.
    /// </summary>
    [IsoId("_pgDKsKoMEemdLtwzt4CWxg")]
    [DisplayName("Margin Lending")]
    public partial record MarginLending : TransactionLoanData9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Date on which the reportable event pertaining to the transaction and captured by the report took place.
        /// </summary>
        [IsoId("_vFPjgaoKEemdLtwzt4CWxg")]
        [DisplayName("Event Date")]
        [IsoXmlTag("EvtDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public required IsoISODate EventDate { get; init; } 
        
        /// <summary>
        /// Unique trade Identifier (UTI) as agreed with the other counterparty.
        /// </summary>
        [IsoId("_tnAD4aoKEemdLtwzt4CWxg")]
        [DisplayName("Unique Trade Identifier")]
        [IsoXmlTag("UnqTradIdr")]
        [IsoSimpleType(IsoSimpleType.Max52Text)]
        [StringLength(maximumLength: 52 ,MinimumLength = 1)]
        public IsoMax52Text? UniqueTradeIdentifier { get; init; } 
        
        /// <summary>
        /// Reference to master agreement under which the counterparties concluded a documented transaction.
        /// </summary>
        [IsoId("_tnAD46oKEemdLtwzt4CWxg")]
        [DisplayName("Master Agreement")]
        [IsoXmlTag("MstrAgrmt")]
        public MasterAgreement6? MasterAgreement { get; init; } 
        
        
        #nullable disable
        
    }
}
