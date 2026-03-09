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
/// Details an individuation of the classification type of the financial instrument.
/// </summary>
[IsoId("_NHRMYX5xEeasY4u9QTizPQ")]
[DisplayName("Securities Instrument Classification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record SecuritiesInstrumentClassification2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a SecuritiesInstrumentClassification2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public SecuritiesInstrumentClassification2( System.String reqIdentifier,Period4Choice_ reqValidityPeriod )
    {
        Identifier = reqIdentifier;
        ValidityPeriod = reqValidityPeriod;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identifier of the financial instrument classification type code.
    /// </summary>
    [IsoId("_NP5j8X5xEeasY4u9QTizPQ")]
    [DisplayName("Identifier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Idr")]
    #endif
    [IsoXmlTag("Idr")]
    [IsoSimpleType(IsoSimpleType.CFIOct2015Identifier)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoCFIOct2015Identifier Identifier { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identifier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identifier { get; init; } 
    #else
    public System.String Identifier { get; set; } 
    #endif
    
    /// <summary>
    /// Modification status for the record compared to the previous report.
    /// </summary>
    [IsoId("_NP5j835xEeasY4u9QTizPQ")]
    [DisplayName("Modification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Mod")]
    #endif
    [IsoXmlTag("Mod")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Modification1Code? Modification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Modification1Code? Modification { get; init; } 
    #else
    public Modification1Code? Modification { get; set; } 
    #endif
    
    /// <summary>
    /// Details the validity of the specific record.
    /// Usage:
    /// Within MiFIR, the FromDate is populated while the instrument is valid. From Date To Date is only populated when the record is being invalidated.
    /// </summary>
    [IsoId("_NP5j9X5xEeasY4u9QTizPQ")]
    [DisplayName("Validity Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtyPrd")]
    #endif
    [IsoXmlTag("VldtyPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required Period4Choice_ ValidityPeriod { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required Period4Choice_ ValidityPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period4Choice_ ValidityPeriod { get; init; } 
    #else
    public Period4Choice_ ValidityPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Date when this record was last modified.
    /// </summary>
    [IsoId("_NP5j935xEeasY4u9QTizPQ")]
    [DisplayName("Last Updated")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastUpdtd")]
    #endif
    [IsoXmlTag("LastUpdtd")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? LastUpdated { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? LastUpdated { get; init; } 
    #else
    public System.DateOnly? LastUpdated { get; set; } 
    #endif
    
    
    #nullable disable
    
}
