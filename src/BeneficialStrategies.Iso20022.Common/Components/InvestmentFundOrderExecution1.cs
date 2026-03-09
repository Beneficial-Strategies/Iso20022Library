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
/// Reference of an order, deal reference, client reference and master reference.
/// </summary>
[IsoId("_R60r-dp-Ed-ak6NoX_4Aeg_-571676430")]
[DisplayName("Investment Fund Order Execution")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvestmentFundOrderExecution1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvestmentFundOrderExecution1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvestmentFundOrderExecution1( System.String reqAmendmentIndicator )
    {
        AmendmentIndicator = reqAmendmentIndicator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique and unambiguous identifier for a group of individual orders, as assigned by the instructing party. This identifier links the individual orders together.
    /// </summary>
    [IsoId("_R60r-tp-Ed-ak6NoX_4Aeg_-1894994328")]
    [DisplayName("Master Reference")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MstrRef")]
    #endif
    [IsoXmlTag("MstrRef")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? MasterReference { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? MasterReference { get; init; } 
    #else
    public System.String? MasterReference { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether a confirmation amendment message will follow the confirmation cancellation instruction or not.
    /// </summary>
    [IsoId("_R60r-9p-Ed-ak6NoX_4Aeg_-314609339")]
    [DisplayName("Amendment Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AmdmntInd")]
    #endif
    [IsoXmlTag("AmdmntInd")]
    [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoYesNoIndicator AmendmentIndicator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String AmendmentIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String AmendmentIndicator { get; init; } 
    #else
    public System.String AmendmentIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Reference of an order, client or deal reference.
    /// </summary>
    [IsoId("_R60r_Np-Ed-ak6NoX_4Aeg_-424772693")]
    [DisplayName("Order References")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrdrRefs")]
    #endif
    [IsoXmlTag("OrdrRefs")]
    public ValueList<InvestmentFundOrderExecution2> OrderReferences { get; init; } = new ValueList<InvestmentFundOrderExecution2>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _R60r_Np-Ed-ak6NoX_4Aeg_-424772693
    
    
    #nullable disable
    
}
