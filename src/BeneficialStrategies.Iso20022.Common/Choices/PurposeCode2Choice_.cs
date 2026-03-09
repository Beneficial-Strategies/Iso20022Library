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
    /// Choice between a code and or a data source scheme to determine the account type.
    /// </summary>
    [KnownType(typeof(PurposeCode2Choice.Code))]
    [KnownType(typeof(PurposeCode2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PurposeCode2Choice.Code),nameof(PurposeCode2Choice.Code))]
    [JsonDerivedType(typeof(PurposeCode2Choice.Proprietary),nameof(PurposeCode2Choice.Proprietary))]
    #endif
    [IsoId("_Qwdxotp-Ed-ak6NoX_4Aeg_264236382")]
    [DisplayName("Purpose Code 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PurposeCode2Choice_
    #else
    public abstract partial class PurposeCode2Choice_
    #endif
    {
    }
}
