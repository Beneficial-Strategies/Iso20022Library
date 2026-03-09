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
/// Report entry details.
/// </summary>
[IsoId("_WH67kBj6EeapYKOltfjd7A")]
[DisplayName("CBRF Report Entry")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CBRFReportEntry1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CBRFReportEntry1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CBRFReportEntry1( System.String reqMessageName,System.String reqTotalNumberOfEntries )
    {
        MessageName = reqMessageName;
        TotalNumberOfEntries = reqTotalNumberOfEntries;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Name of the message.
    /// </summary>
    [IsoId("_pRNgoBj6EeapYKOltfjd7A")]
    [DisplayName("Message Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgNm")]
    #endif
    [IsoXmlTag("MsgNm")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax35Text MessageName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String MessageName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String MessageName { get; init; } 
    #else
    public System.String MessageName { get; set; } 
    #endif
    
    /// <summary>
    /// Total number of entries in the group.
    /// </summary>
    [IsoId("_dXICUBj8EeapYKOltfjd7A")]
    [DisplayName("Total Number Of Entries")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TtlNbOfNtries")]
    #endif
    [IsoXmlTag("TtlNbOfNtries")]
    [IsoSimpleType(IsoSimpleType.Max9NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax9NumericText TotalNumberOfEntries { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TotalNumberOfEntries { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TotalNumberOfEntries { get; init; } 
    #else
    public System.String TotalNumberOfEntries { get; set; } 
    #endif
    
    /// <summary>
    /// Information identifying electronic messages.
    /// </summary>
    [IsoId("_99e7YBj6EeapYKOltfjd7A")]
    [DisplayName("Message Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MsgDtls")]
    #endif
    [IsoXmlTag("MsgDtls")]
    public ValueList<ElectronicMessageDetails1> MessageDetails { get; init; } = new ValueList<ElectronicMessageDetails1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _99e7YBj6EeapYKOltfjd7A
    
    
    #nullable disable
    
}
