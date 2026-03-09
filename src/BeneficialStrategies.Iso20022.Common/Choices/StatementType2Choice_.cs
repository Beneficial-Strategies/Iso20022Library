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
    /// Choice of format for the statement type.
    /// </summary>
    [KnownType(typeof(StatementType2Choice.Code))]
    [KnownType(typeof(StatementType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(StatementType2Choice.Code),nameof(StatementType2Choice.Code))]
    [JsonDerivedType(typeof(StatementType2Choice.Proprietary),nameof(StatementType2Choice.Proprietary))]
    #endif
    [IsoId("_QrZre9p-Ed-ak6NoX_4Aeg_1714692678")]
    [DisplayName("Statement Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record StatementType2Choice_
    #else
    public abstract partial class StatementType2Choice_
    #endif
    {
    }
}
