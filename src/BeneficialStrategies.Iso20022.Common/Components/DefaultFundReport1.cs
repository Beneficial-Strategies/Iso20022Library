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
/// Provides details on the calculation of the default fund and the collateral that has been posted by the clearing member.
/// </summary>
[IsoId("_-ddILaMOEeCojJW5vEuTEQ_1402285716")]
[DisplayName("Default Fund Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DefaultFundReport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a DefaultFundReport1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public DefaultFundReport1( AmountAndDirection21 reqNetExcessOrDeficit )
    {
        NetExcessOrDeficit = reqNetExcessOrDeficit;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Provides details about the calculation of the clearing member contribution to the default fund.
    /// </summary>
    [IsoId("_-ddILqMOEeCojJW5vEuTEQ_1576502363")]
    [DisplayName("Default Fund Calculation")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DfltFndClctn")]
    #endif
    [IsoXmlTag("DfltFndClctn")]
    public ValueList<DefaultFund1> DefaultFundCalculation { get; init; } = new ValueList<DefaultFund1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _-ddILqMOEeCojJW5vEuTEQ_1576502363
    
    /// <summary>
    /// Provides details about the collateral held.
    /// </summary>
    [IsoId("_-ddIL6MOEeCojJW5vEuTEQ_-1115881016")]
    [DisplayName("Collateral Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CollDesc")]
    #endif
    [IsoXmlTag("CollDesc")]
    public ValueList<Collateral3> CollateralDescription { get; init; } = new ValueList<Collateral3>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _-ddIL6MOEeCojJW5vEuTEQ_-1115881016
    
    /// <summary>
    /// Excess amount that the central counterparty will restitute to the clearing member or deficit to be provided by the member for the guarantee fund.
    /// </summary>
    [IsoId("_-dm5IKMOEeCojJW5vEuTEQ_-1642876959")]
    [DisplayName("Net Excess Or Deficit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NetXcssOrDfcit")]
    #endif
    [IsoXmlTag("NetXcssOrDfcit")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required AmountAndDirection21 NetExcessOrDeficit { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required AmountAndDirection21 NetExcessOrDeficit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AmountAndDirection21 NetExcessOrDeficit { get; init; } 
    #else
    public AmountAndDirection21 NetExcessOrDeficit { get; set; } 
    #endif
    
    
    #nullable disable
    
}
