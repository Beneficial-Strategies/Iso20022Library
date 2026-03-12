// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Deposit service provided by the ATM inside the session.
/// </summary>
[IsoId("_fRt8wa3-EeWL1uap3dNhCQ")]
[DisplayName("ATM Service")]
public partial record ATMService11
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the deposit service provided by the ATM inside the session.
    /// </summary>
    [IsoId("_fdDDAa3-EeWL1uap3dNhCQ")]
    [DisplayName("Service Reference")]
    [IsoXmlTag("SvcRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ServiceReference { get; init; } 
    
    /// <summary>
    /// Codification of the type of service for the ATM.
    /// </summary>
    [IsoId("_fdDDA63-EeWL1uap3dNhCQ")]
    [DisplayName("ATM Service Code")]
    [IsoXmlTag("ATMSvcCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ATMServiceCode { get; init; } 
    
    /// <summary>
    /// Describes the type of deposit service selected by the customer.
    /// </summary>
    [IsoId("_fdDDBa3-EeWL1uap3dNhCQ")]
    [DisplayName("Service Type")]
    [IsoXmlTag("SvcTp")]
    public required ATMServiceType6Code ServiceType { get; init; } 
    
    /// <summary>
    /// Identification of the variant of the service.
    /// </summary>
    [IsoId("_fdDDB63-EeWL1uap3dNhCQ")]
    [DisplayName("Service Variant Identification")]
    [IsoXmlTag("SvcVarntId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ServiceVariantIdentification { get; init; } 
    
    /// <summary>
    /// True if deposit with cash back transaction.
    /// </summary>
    [IsoId("_lZk2YK3_EeWL1uap3dNhCQ")]
    [DisplayName("Cash Back")]
    [IsoXmlTag("CshBck")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? CashBack { get; init; } 
    
    /// <summary>
    /// True if the deposit transaction is split in multiple accounts.
    /// </summary>
    [IsoId("_pnrOgK3_EeWL1uap3dNhCQ")]
    [DisplayName("Multi Account")]
    [IsoXmlTag("MultiAcct")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? MultiAccount { get; init; } 
    
    
    #nullable disable
    
}
