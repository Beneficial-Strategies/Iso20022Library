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
/// Provides additional information regarding corporate action option cash movement details.
/// </summary>
[IsoId("_1fvcIjL3EeKU9IrkkToqcw_-1926320982")]
[DisplayName("Cash Option SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CashOptionSD5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CashOptionSD5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CashOptionSD5( System.String reqPlaceAndName,System.String reqPayoutNumber,DTCCPayoutType1Code reqPayoutType,WorkflowStatus1Code reqPayoutStatus )
    {
        PlaceAndName = reqPlaceAndName;
        PayoutNumber = reqPayoutNumber;
        PayoutType = reqPayoutType;
        PayoutStatus = reqPayoutStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1fvcIzL3EeKU9IrkkToqcw_-962139710")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Unique number associated with a payout within an option.
    /// </summary>
    [IsoId("_1fvcJDL3EeKU9IrkkToqcw_1452521946")]
    [DisplayName("Payout Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyoutNb")]
    #endif
    [IsoXmlTag("PyoutNb")]
    [IsoSimpleType(IsoSimpleType.Exact3NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact3NumericText PayoutNumber { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PayoutNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PayoutNumber { get; init; } 
    #else
    public System.String PayoutNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Describes the type of payout associated with the event.
    /// </summary>
    [IsoId("_1fvcJTL3EeKU9IrkkToqcw_341610527")]
    [DisplayName("Payout Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyoutTp")]
    #endif
    [IsoXmlTag("PyoutTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCCPayoutType1Code PayoutType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DTCCPayoutType1Code PayoutType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCPayoutType1Code PayoutType { get; init; } 
    #else
    public DTCCPayoutType1Code PayoutType { get; set; } 
    #endif
    
    /// <summary>
    /// Workflow status of the payout.
    /// </summary>
    [IsoId("_1fvcJjL3EeKU9IrkkToqcw_1640647389")]
    [DisplayName("Payout Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyoutSts")]
    #endif
    [IsoXmlTag("PyoutSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required WorkflowStatus1Code PayoutStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required WorkflowStatus1Code PayoutStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public WorkflowStatus1Code PayoutStatus { get; init; } 
    #else
    public WorkflowStatus1Code PayoutStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Maximum withholding rate based on the country of the sourced income.
    /// </summary>
    [IsoId("_1f4mEDL3EeKU9IrkkToqcw_836812695")]
    [DisplayName("Maximum Withholding Tax Percentage")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MaxWhldgTaxPctg")]
    #endif
    [IsoXmlTag("MaxWhldgTaxPctg")]
    [IsoSimpleType(IsoSimpleType.PercentageRate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoPercentageRate? MaximumWithholdingTaxPercentage { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.Decimal? MaximumWithholdingTaxPercentage { get; init; } 
    #else
    public System.Decimal? MaximumWithholdingTaxPercentage { get; set; } 
    #endif
    
    
    #nullable disable
    
}
