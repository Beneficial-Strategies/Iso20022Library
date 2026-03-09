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
/// Provides additional information regarding corporate action option securities movement details.
/// </summary>
[IsoId("_1gMIEjL3EeKU9IrkkToqcw_385488940")]
[DisplayName("Securities Option SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesOptionSD4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesOptionSD4 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesOptionSD4( System.String reqPlaceAndName,System.String reqPayoutNumber,DTCCPayoutType2Code reqPayoutType,WorkflowStatus1Code reqPayoutStatus )
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
    [IsoId("_1gMIEzL3EeKU9IrkkToqcw_-611583413")]
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
    [IsoId("_1gMIFDL3EeKU9IrkkToqcw_260551097")]
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
    [IsoId("_1gMIFTL3EeKU9IrkkToqcw_-1542715842")]
    [DisplayName("Payout Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PyoutTp")]
    #endif
    [IsoXmlTag("PyoutTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required DTCCPayoutType2Code PayoutType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required DTCCPayoutType2Code PayoutType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCPayoutType2Code PayoutType { get; init; } 
    #else
    public DTCCPayoutType2Code PayoutType { get; set; } 
    #endif
    
    /// <summary>
    /// Workflow status of the payout.
    /// </summary>
    [IsoId("_1gVSADL3EeKU9IrkkToqcw_29434994")]
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
    
    
    #nullable disable
    
}
