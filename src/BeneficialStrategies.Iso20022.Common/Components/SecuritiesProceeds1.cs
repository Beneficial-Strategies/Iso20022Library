// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides securities proceeds information.
/// </summary>
[IsoId("_UK6fR9p-Ed-ak6NoX_4Aeg_1911486700")]
[DisplayName("Securities Proceeds")]
public partial record SecuritiesProceeds1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UK6fSNp-Ed-ak6NoX_4Aeg_-1868154085")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// The quantity of financial instruments that is posted.
    /// </summary>
    [IsoId("_UK6fSdp-Ed-ak6NoX_4Aeg_-1868154084")]
    [DisplayName("Posting Quantity")]
    [IsoXmlTag("PstngQty")]
    public required UnitOrFaceAmount1Choice_ PostingQuantity { get; init; } 
    
    /// <summary>
    /// Provides information about the account that is debited/credited.
    /// </summary>
    [IsoId("_UK6fStp-Ed-ak6NoX_4Aeg_-1386075125")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<SecuritiesAccount10> AccountDetails { get; init; } = new ValueList<SecuritiesAccount10>(){};
    
    /// <summary>
    /// Provides reconciliation information.
    /// </summary>
    [IsoId("_UK6fS9p-Ed-ak6NoX_4Aeg_1005212096")]
    [DisplayName("Reconciliation Details")]
    [IsoXmlTag("RcncltnDtls")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public IsoMax350Text? ReconciliationDetails { get; init; } 
    
    
    #nullable disable
    
}
