// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Payment instrument between a debtor and a creditor, which flows through one or more financial institutions or systems.
/// </summary>
[IsoId("_VRiwJNp-Ed-ak6NoX_4Aeg_-1711379647")]
[DisplayName("Credit Transfer")]
public partial record CreditTransfer3
{
    #nullable enable
    
    /// <summary>
    /// Information supplied to enable the matching of an entry with the items that the transfer is intended to settle, such as commercial invoices in an accounts&apos; receivable system.
    /// </summary>
    [IsoId("_VRiwJdp-Ed-ak6NoX_4Aeg_-1711379630")]
    [DisplayName("Reference")]
    [IsoXmlTag("Ref")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Reference { get; init; } 
    
    /// <summary>
    /// Party that receives an amount of money from the debtor. The creditor is also the credit account owner.
    /// </summary>
    [IsoId("_VRiwJtp-Ed-ak6NoX_4Aeg_-1711379576")]
    [DisplayName("Creditor Details")]
    [IsoXmlTag("CdtrDtls")]
    public required Creditor2 CreditorDetails { get; init; } 
    
    /// <summary>
    /// Party that owes an amount of money to the creditor. The debtor is also the debit account owner.
    /// </summary>
    [IsoId("_VRiwJ9p-Ed-ak6NoX_4Aeg_-1711379585")]
    [DisplayName("Debtor Details")]
    [IsoXmlTag("DbtrDtls")]
    public Debtor2? DebtorDetails { get; init; } 
    
    
    #nullable disable
    
}
