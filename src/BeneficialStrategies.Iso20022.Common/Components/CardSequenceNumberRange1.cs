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
/// Range of sequence numbers related to card transactions.
/// </summary>
[IsoId("_t5o4wVkyEeGeoaLUQk__nA_-981636366")]
[DisplayName("Card Sequence Number Range")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CardSequenceNumberRange1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// CardSequenceNumberRange1: FirstTransactionSequenceNumberMessage element to be finalised once feedback from Card SEG has been received.
    /// </summary>
    [IsoId("_t5o4wlkyEeGeoaLUQk__nA_1543954032")]
    [DisplayName("First Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FrstTx")]
    #endif
    [IsoXmlTag("FrstTx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? FirstTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? FirstTransaction { get; init; } 
    #else
    public System.String? FirstTransaction { get; set; } 
    #endif
    
    /// <summary>
    /// CardSequenceNumberRange1: LastTransactionSequenceNumberMessage element to be finalised once feedback from Card SEG has been received.
    /// </summary>
    [IsoId("_t5ypwFkyEeGeoaLUQk__nA_407420783")]
    [DisplayName("Last Transaction")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LastTx")]
    #endif
    [IsoXmlTag("LastTx")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? LastTransaction { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? LastTransaction { get; init; } 
    #else
    public System.String? LastTransaction { get; set; } 
    #endif
    
    
    #nullable disable
    
}
