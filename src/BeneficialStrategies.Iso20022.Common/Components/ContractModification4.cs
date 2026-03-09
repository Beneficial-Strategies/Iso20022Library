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
/// Information related to the action type.
/// </summary>
[IsoId("_HVwgcwxhEeuoAcnnpX2x_w")]
[DisplayName("Contract Modification")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ContractModification4
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indication of the action type of the transaction.
    /// </summary>
    [IsoId("_HVwgdQxhEeuoAcnnpX2x_w")]
    [DisplayName("Action Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActnTp")]
    #endif
    [IsoXmlTag("ActnTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionOperationType7Code? ActionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionOperationType7Code? ActionType { get; init; } 
    #else
    public TransactionOperationType7Code? ActionType { get; set; } 
    #endif
    
    /// <summary>
    /// Indication whether the report is done at trade or position level.
    /// </summary>
    [IsoId("_HVwgdAxhEeuoAcnnpX2x_w")]
    [DisplayName("Level")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Lvl")]
    #endif
    [IsoXmlTag("Lvl")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ModificationLevel1Code? Level { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ModificationLevel1Code? Level { get; init; } 
    #else
    public ModificationLevel1Code? Level { get; set; } 
    #endif
    
    
    #nullable disable
    
}
