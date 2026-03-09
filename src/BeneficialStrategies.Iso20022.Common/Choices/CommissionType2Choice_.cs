// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the commission type.
    /// </summary>
    [KnownType(typeof(CommissionType2Choice.Code))]
    [KnownType(typeof(CommissionType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CommissionType2Choice.Code),nameof(CommissionType2Choice.Code))]
    [JsonDerivedType(typeof(CommissionType2Choice.Proprietary),nameof(CommissionType2Choice.Proprietary))]
    #endif
    [IsoId("_Ac_TctokEeC60axPepSq7g_1955335824")]
    [DisplayName("Commission Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CommissionType2Choice_
    #else
    public abstract partial class CommissionType2Choice_
    #endif
    {
    }
}
