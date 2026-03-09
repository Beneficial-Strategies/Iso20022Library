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
/// Specifies the attributes of the party, which are / are being updated.
/// </summary>
[IsoId("_oZdVsPH1Eeaz_YGUGLjP6A")]
[DisplayName("Party Update")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PartyUpdate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a PartyUpdate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public PartyUpdate1( PartyIdentification136 reqIdentification,PartyDetail1 reqOther )
    {
        Identification = reqIdentification;
        Other = reqOther;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// </summary>
    [IsoId("_3j8_ITbvEeeYhaZ6bvG1Xg")]
    [DisplayName("Technical Record Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechRcrdId")]
    #endif
    [IsoXmlTag("TechRcrdId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TechnicalRecordIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TechnicalRecordIdentification { get; init; } 
    #else
    public System.String? TechnicalRecordIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_7OkLIPmjEeak-cGuSQTPwg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification136 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification136 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136 Identification { get; init; } 
    #else
    public PartyIdentification136 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Unique identification of the party, as previously defined.
    /// </summary>
    [IsoId("_pemdMEn3EeexwKvkdw4OGA")]
    [DisplayName("Previous Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PrvsId")]
    #endif
    [IsoXmlTag("PrvsId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? PreviousIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? PreviousIdentification { get; init; } 
    #else
    public PartyIdentification136? PreviousIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Any other additional information about the party.
    /// </summary>
    [IsoId("_a3_3AvmkEeak-cGuSQTPwg")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyDetail1 Other { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyDetail1 Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyDetail1 Other { get; init; } 
    #else
    public PartyDetail1 Other { get; set; } 
    #endif
    
    /// <summary>
    /// Information about decision taken by a relevant institution concerning the party.
    /// </summary>
    [IsoId("_IffBgPH3Eeaz_YGUGLjP6A")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    public ValueList<StatusDetail1> Status { get; init; } = new ValueList<StatusDetail1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _IffBgPH3Eeaz_YGUGLjP6A
    
    /// <summary>
    /// Period of time when the associated record is technically valid.
    /// </summary>
    [IsoId("_BoOKUTb5EeeYhaZ6bvG1Xg")]
    [DisplayName("Technical Validity Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TechVldtyPrd")]
    #endif
    [IsoXmlTag("TechVldtyPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period4Choice_? TechnicalValidityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_? TechnicalValidityPeriod { get; init; } 
    #else
    public Period4Choice_? TechnicalValidityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information that can not be captured in the structured fields and/or any other specific block.
    /// </summary>
    [IsoId("_5O9IYTbvEeeYhaZ6bvG1Xg")]
    [DisplayName("Supplementary Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SplmtryData")]
    #endif
    [IsoXmlTag("SplmtryData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SupplementaryData1? SupplementaryData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SupplementaryData1? SupplementaryData { get; init; } 
    #else
    public SupplementaryData1? SupplementaryData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
