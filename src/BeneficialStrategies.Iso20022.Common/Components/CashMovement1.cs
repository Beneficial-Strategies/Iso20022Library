// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides information about the cash movement.
/// </summary>
[IsoId("_UI-lk9p-Ed-ak6NoX_4Aeg_1684857484")]
[DisplayName("Cash Movement")]
public partial record CashMovement1
{
    #nullable enable
    
    /// <summary>
    /// Identification of the movement.
    /// </summary>
    [IsoId("_UI-llNp-Ed-ak6NoX_4Aeg_-1914698065")]
    [DisplayName("Movement Identification")]
    [IsoXmlTag("MvmntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? MovementIdentification { get; init; } 
    
    /// <summary>
    /// Cash amount.
    /// </summary>
    [IsoId("_UI-lldp-Ed-ak6NoX_4Aeg_-1954409437")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public required ActiveCurrencyAndAmount Amount { get; init; } 
    
    /// <summary>
    /// Amount of taxes.
    /// </summary>
    [IsoId("_UI-lltp-Ed-ak6NoX_4Aeg_-1850976432")]
    [DisplayName("Tax Amount")]
    [IsoXmlTag("TaxAmt")]
    public ActiveCurrencyAndAmount? TaxAmount { get; init; } 
    
    /// <summary>
    /// Specifies the charges.
    /// </summary>
    [IsoId("_UI-ll9p-Ed-ak6NoX_4Aeg_1122249828")]
    [DisplayName("Charges")]
    [IsoXmlTag("Chrgs")]
    public Charges1? Charges { get; init; } 
    
    /// <summary>
    /// Provides information about the account which is debited/credited.
    /// </summary>
    [IsoId("_UI-lmNp-Ed-ak6NoX_4Aeg_-802817583")]
    [DisplayName("Account Details")]
    [IsoXmlTag("AcctDtls")]
    [MinLength(1)]
    [MaxLength(2)]
    public ValueList<CashAccount18> AccountDetails { get; init; } = new ValueList<CashAccount18>(){};
    
    
    #nullable disable
    
}
