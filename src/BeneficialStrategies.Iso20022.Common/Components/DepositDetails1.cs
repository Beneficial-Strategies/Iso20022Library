// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Additional functions or services to be performed in conjunction with the transaction.
/// </summary>
[IsoId("_akYT49CHEei_pMueJh_zOA")]
[DisplayName("Deposit Details")]
public partial record DepositDetails1
{
    #nullable enable
    
    /// <summary>
    /// Funding source used for deposit.
    /// </summary>
    [IsoId("_akYT5NCHEei_pMueJh_zOA")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public required CardDepositType1Code Type { get; init; } 
    
    /// <summary>
    /// Other funding source used for deposit.
    /// </summary>
    [IsoId("_akYT5dCHEei_pMueJh_zOA")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    /// <summary>
    /// Amount of the deposit.
    /// </summary>
    [IsoId("_kT6e0NCIEei_pMueJh_zOA")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public Amount5? Amount { get; init; } 
    
    
    #nullable disable
    
}
