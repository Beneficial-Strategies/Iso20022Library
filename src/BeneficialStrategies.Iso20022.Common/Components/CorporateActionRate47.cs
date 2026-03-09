// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies rates related to a corporate action option.
/// </summary>
[IsoId("_S9DdASeQEeOXAt_43VmZGw")]
[DisplayName("Corporate Action Rate")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionRate47
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Rate proposed in a remarketing of variable rate notes.
    /// </summary>
    [IsoId("_TUa0ISeQEeOXAt_43VmZGw")]
    [DisplayName("Proposed Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PropsdRate")]
    #endif
    [IsoXmlTag("PropsdRate")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? ProposedRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? ProposedRate { get; init; } 
    #else
    public System.Decimal? ProposedRate { get; set; } 
    #endif
    
    /// <summary>
    /// Rate of allowed over-subscription.
    /// </summary>
    [IsoId("_TUa0KSeQEeOXAt_43VmZGw")]
    [DisplayName("Oversubscription Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OvrsbcptRate")]
    #endif
    [IsoXmlTag("OvrsbcptRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat5Choice_? OversubscriptionRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat5Choice_? OversubscriptionRate { get; init; } 
    #else
    public RateAndAmountFormat5Choice_? OversubscriptionRate { get; set; } 
    #endif
    
    /// <summary>
    /// Requested tax rate in case of breakdown of tax rate, for example, used for adjustment of tax rate. This is the new requested applicable rate.
    /// </summary>
    [IsoId("_TUa0MSeQEeOXAt_43VmZGw")]
    [DisplayName("Requested Taxation Rate")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdTaxtnRate")]
    #endif
    [IsoXmlTag("ReqdTaxtnRate")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat21Choice_? RequestedTaxationRate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat21Choice_? RequestedTaxationRate { get; init; } 
    #else
    public RateAndAmountFormat21Choice_? RequestedTaxationRate { get; set; } 
    #endif
    
    /// <summary>
    /// Requested rate at which the income will be withheld by the jurisdiction in which the income was originally paid, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_bZ3RQieQEeOXAt_43VmZGw")]
    [DisplayName("Requested Withholding Of Foreign Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdWhldgOfFrgnTax")]
    #endif
    [IsoXmlTag("ReqdWhldgOfFrgnTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat21Choice_? RequestedWithholdingOfForeignTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat21Choice_? RequestedWithholdingOfForeignTax { get; init; } 
    #else
    public RateAndAmountFormat21Choice_? RequestedWithholdingOfForeignTax { get; set; } 
    #endif
    
    /// <summary>
    /// Requested rate at which the income will be withheld by the jurisdiction in which the account owner is located, for which relief at source and/or reclaim may be possible.
    /// </summary>
    [IsoId("_bZ3RQyeQEeOXAt_43VmZGw")]
    [DisplayName("Requested Withholding Of Local Tax")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ReqdWhldgOfLclTax")]
    #endif
    [IsoXmlTag("ReqdWhldgOfLclTax")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RateAndAmountFormat21Choice_? RequestedWithholdingOfLocalTax { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RateAndAmountFormat21Choice_? RequestedWithholdingOfLocalTax { get; init; } 
    #else
    public RateAndAmountFormat21Choice_? RequestedWithholdingOfLocalTax { get; set; } 
    #endif
    
    
    #nullable disable
    
}
