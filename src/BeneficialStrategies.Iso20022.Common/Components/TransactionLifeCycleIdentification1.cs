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
/// Unique global identification structure used to match transactions throughout their lifecycle (for example, authorisation to financial, financial to chargebacks, etc.). 
/// It shall contain the same value in all messages throughout a transaction&apos;s lifecycle.
/// ISO 8583:2003 bit 21
/// </summary>
[IsoId("_5kV_sER7Eeeb1MmUPTrSMw")]
[DisplayName("Transaction Life Cycle Identification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TransactionLifeCycleIdentification1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TransactionLifeCycleIdentification1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TransactionLifeCycleIdentification1( System.String reqIdentification )
    {
        Identification = reqIdentification;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Unique transaction identifier.
    /// ISO 8583:2003 bit 21-2
    /// </summary>
    [IsoId("_URUEoKdZEeiva6IOmhpVHw")]
    [DisplayName("Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Id")]
    #endif
    [IsoXmlTag("Id")]
    [IsoSimpleType(IsoSimpleType.Exact15Text)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact15Text Identification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String Identification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String Identification { get; init; } 
    #else
    public System.String Identification { get; set; } 
    #endif
    
    /// <summary>
    /// Contains authorisation sequence number.
    /// </summary>
    [IsoId("_uA1W0KdZEeiva6IOmhpVHw")]
    [DisplayName("Authorisation Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthstnSeqNb")]
    #endif
    [IsoXmlTag("AuthstnSeqNb")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact2NumericText? AuthorisationSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthorisationSequenceNumber { get; init; } 
    #else
    public System.String? AuthorisationSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Number used with trace identifier to uniquely identify where a single authorisation was obtained covering a number of financial presentments.
    /// ISO 8583:2003 bit 21-3
    /// </summary>
    [IsoId("_27MCsKdZEeiva6IOmhpVHw")]
    [DisplayName("Presentment Sequence Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntmntSeqNb")]
    #endif
    [IsoXmlTag("PresntmntSeqNb")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact2NumericText? PresentmentSequenceNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PresentmentSequenceNumber { get; init; } 
    #else
    public System.String? PresentmentSequenceNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Expected maximum number of presentments for this transaction.
    /// </summary>
    [IsoId("_8vlqQKdZEeiva6IOmhpVHw")]
    [DisplayName("Presentment Sequence Count")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PresntmntSeqCnt")]
    #endif
    [IsoXmlTag("PresntmntSeqCnt")]
    [IsoSimpleType(IsoSimpleType.Exact2NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoExact2NumericText? PresentmentSequenceCount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PresentmentSequenceCount { get; init; } 
    #else
    public System.String? PresentmentSequenceCount { get; set; } 
    #endif
    
    /// <summary>
    /// Code calculated using an algorithm against key transaction data elements that are common to both authorisation and financial messages.
    /// ISO 8583:2003 bit 21-4
    /// </summary>
    [IsoId("_A0fqIKdaEeiva6IOmhpVHw")]
    [DisplayName("Authentication Token")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AuthntcnTkn")]
    #endif
    [IsoXmlTag("AuthntcnTkn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AuthenticationToken { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AuthenticationToken { get; init; } 
    #else
    public System.String? AuthenticationToken { get; set; } 
    #endif
    
    
    #nullable disable
    
}
