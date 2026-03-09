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
/// Data to request a stored value service (prepaid card or account).
/// </summary>
[IsoId("_dKP-sXG0Ee2TbaNWBpRZpQ")]
[DisplayName("Stored Value Request")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StoredValueRequest6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Sale System identification of the transaction in an unambiguous way.
    /// </summary>
    [IsoId("_dQkpIXG0Ee2TbaNWBpRZpQ")]
    [DisplayName("Sale Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SaleTxId")]
    #endif
    [IsoXmlTag("SaleTxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentifier1? SaleTransactionIdentification { get; init; } 
    #else
    public TransactionIdentifier1? SaleTransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to the stored value card.
    /// </summary>
    [IsoId("_dQkpI3G0Ee2TbaNWBpRZpQ")]
    [DisplayName("Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Data")]
    #endif
    [IsoXmlTag("Data")]
    public ValueList<StoredValueData6> Data { get; init; } = new ValueList<StoredValueData6>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _dQkpI3G0Ee2TbaNWBpRZpQ
    
    
    #nullable disable
    
}
