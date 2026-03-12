// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the securities movement.
/// </summary>
[IsoId("_UIO-tNp-Ed-ak6NoX_4Aeg_1695017809")]
[DisplayName("Security Movement")]
public partial record SecurityMovement1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the movement.
    /// </summary>
    [IsoId("_UIO-tdp-Ed-ak6NoX_4Aeg_-1539092088")]
    [DisplayName("Movement Identification")]
    [IsoXmlTag("MvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MovementIdentification { get; init; } 
    
    /// <summary>
    /// Identification of the financial instrument.
    /// </summary>
    [IsoId("_UIO-ttp-Ed-ak6NoX_4Aeg_-1084454454")]
    [DisplayName("Security Identification")]
    [IsoXmlTag("SctyId")]
    public required SecurityIdentification7 SecurityIdentification { get; init; } 
    
    /// <summary>
    /// Quantitty of financial instrument.
    /// </summary>
    [IsoId("_UIO-t9p-Ed-ak6NoX_4Aeg_-494324592")]
    [DisplayName("Securities Quantity")]
    [IsoXmlTag("SctiesQty")]
    public required UnitOrFaceAmount1Choice_ SecuritiesQuantity { get; init; } 
    
    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    [IsoId("_UIO-uNp-Ed-ak6NoX_4Aeg_139176688")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<SecuritiesAccount12> AccountDetails { get; init; } = new ValueList<SecuritiesAccount12>(){};
    
    
    #nullable disable
    
}
