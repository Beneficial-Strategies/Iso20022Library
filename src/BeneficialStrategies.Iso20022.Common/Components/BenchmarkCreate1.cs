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
/// Specifies the attributes of the benchmark, which is / are being created.
/// </summary>
[IsoId("_-mkGetOtEeilDKNlC_3bSg")]
[DisplayName("Benchmark Create")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record BenchmarkCreate1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a BenchmarkCreate1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public BenchmarkCreate1( SecurityIdentification19 reqIdentification,BenchmarkDetail1 reqOther,PartyIdentification136 reqAdministrator )
    {
        Identification = reqIdentification;
        Other = reqOther;
        Administrator = reqAdministrator;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique identifier of a record in a message used as part of error management and status advice messages.
    /// </summary>
    [IsoId("_-mkGfdOtEeilDKNlC_3bSg")]
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
    /// Unique identification of the benchmark.
    /// </summary>
    [IsoId("_-mkGf9OtEeilDKNlC_3bSg")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required SecurityIdentification19 Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required SecurityIdentification19 Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SecurityIdentification19 Identification { get; init; } 
    #else
    public SecurityIdentification19 Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Any other additional information about the benchmark.
    /// </summary>
    [IsoId("_-mktgNOtEeilDKNlC_3bSg")]
    [DisplayName("Other")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Othr")]
    #endif
    [IsoXmlTag("Othr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required BenchmarkDetail1 Other { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required BenchmarkDetail1 Other { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BenchmarkDetail1 Other { get; init; } 
    #else
    public BenchmarkDetail1 Other { get; set; } 
    #endif
    
    /// <summary>
    /// Set of identifiers of the party who is administrating the benchmark.
    /// </summary>
    [IsoId("_-mktg9OtEeilDKNlC_3bSg")]
    [DisplayName("Administrator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Admstr")]
    #endif
    [IsoXmlTag("Admstr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required PartyIdentification136 Administrator { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required PartyIdentification136 Administrator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136 Administrator { get; init; } 
    #else
    public PartyIdentification136 Administrator { get; set; } 
    #endif
    
    /// <summary>
    /// Set of identifiers of the party who is the supervised entity endorsing the benchmark.
    /// </summary>
    [IsoId("_-mktgdOtEeilDKNlC_3bSg")]
    [DisplayName("Endorsing Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="NdrsngPty")]
    #endif
    [IsoXmlTag("NdrsngPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification136? EndorsingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification136? EndorsingParty { get; init; } 
    #else
    public PartyIdentification136? EndorsingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Status of the decision taken by a relevant institution concerning the benchmark.
    /// </summary>
    [IsoId("_-mkGe9OtEeilDKNlC_3bSg")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public StatusDetail1? Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusDetail1? Status { get; init; } 
    #else
    public StatusDetail1? Status { get; set; } 
    #endif
    
    /// <summary>
    /// Period of time when the associated record is technically valid.
    /// </summary>
    [IsoId("_-mktgtOtEeilDKNlC_3bSg")]
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
    [IsoId("_-mkGftOtEeilDKNlC_3bSg")]
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
