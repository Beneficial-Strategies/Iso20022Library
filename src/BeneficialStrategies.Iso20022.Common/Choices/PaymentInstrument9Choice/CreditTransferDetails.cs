// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument9Choice
{
    /// <summary>
    /// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
    /// </summary>
    [IsoId("_VK1rMNp-Ed-ak6NoX_4Aeg_853690870")]
    [DisplayName("Credit Transfer Details")]
    public partial record CreditTransferDetails : PaymentInstrument9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
        /// </summary>
        [IsoId("_VRiwKdp-Ed-ak6NoX_4Aeg_949302766")]
        [DisplayName("Reference")]
        [IsoXmlTag("Ref")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? Reference { get; init; } 
        
        /// <summary>
        /// Party that receives an amount of money from the debtor. The creditor is also the credit account owner.
        /// </summary>
        [IsoId("_VRshINp-Ed-ak6NoX_4Aeg_949302826")]
        [DisplayName("Creditor Details")]
        [IsoXmlTag("CdtrDtls")]
        public Creditor2? CreditorDetails { get; init; } 
        
        /// <summary>
        /// Party that owes the cash to the creditor/final party. The debtor is also the debit account owner.
        /// </summary>
        [IsoId("_VRshIdp-Ed-ak6NoX_4Aeg_949302784")]
        [DisplayName("Debtor Details")]
        [IsoXmlTag("DbtrDtls")]
        public required Debtor2 DebtorDetails { get; init; } 
        
        
        #nullable disable
        
    }
}
