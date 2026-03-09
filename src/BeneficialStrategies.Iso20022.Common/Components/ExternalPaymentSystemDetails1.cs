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
/// Information about external payment system.
/// </summary>
[IsoId("_YG0vwB9yEeapDZRA0Hb6ow")]
[DisplayName("External Payment System Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ExternalPaymentSystemDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ExternalPaymentSystemDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ExternalPaymentSystemDetails1( System.String reqClearingPositionsRegisterAllowedIndicator )
    {
        ClearingPositionsRegisterAllowedIndicator = reqClearingPositionsRegisterAllowedIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the participant can send Register of Clearing Positions.
    /// </summary>
    [IsoId("_s4SMgB9yEeapDZRA0Hb6ow")]
    [DisplayName("Clearing Positions Register Allowed Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrPossRegrAllwdInd")]
    #endif
    [IsoXmlTag("ClrPossRegrAllwdInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator ClearingPositionsRegisterAllowedIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String ClearingPositionsRegisterAllowedIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String ClearingPositionsRegisterAllowedIndicator { get; init; } 
    #else
    public System.String ClearingPositionsRegisterAllowedIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// List of the clearing schemes.
    /// </summary>
    [IsoId("_80z6oB9yEeapDZRA0Hb6ow")]
    [DisplayName("Clearing Circuits")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ClrCrcts")]
    #endif
    [IsoXmlTag("ClrCrcts")]
    public ValueList<ClearingCircuits1> ClearingCircuits { get; init; } = new ValueList<ClearingCircuits1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _80z6oB9yEeapDZRA0Hb6ow
    
    
    #nullable disable
    
}
