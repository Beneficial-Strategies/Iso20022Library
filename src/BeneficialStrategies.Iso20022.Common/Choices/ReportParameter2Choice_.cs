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
    /// Choice between types of reporting parameter.
    /// </summary>
    [KnownType(typeof(ReportParameter2Choice.Party))]
    [KnownType(typeof(ReportParameter2Choice.Country))]
    [KnownType(typeof(ReportParameter2Choice.Currency))]
    [KnownType(typeof(ReportParameter2Choice.UserDefined))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReportParameter2Choice.Party),nameof(ReportParameter2Choice.Party))]
    [JsonDerivedType(typeof(ReportParameter2Choice.Country),nameof(ReportParameter2Choice.Country))]
    [JsonDerivedType(typeof(ReportParameter2Choice.Currency),nameof(ReportParameter2Choice.Currency))]
    [JsonDerivedType(typeof(ReportParameter2Choice.UserDefined),nameof(ReportParameter2Choice.UserDefined))]
    #endif
    [IsoId("_U11EiNp-Ed-ak6NoX_4Aeg_-922147524")]
    [DisplayName("Report Parameter 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReportParameter2Choice_
    #else
    public abstract partial class ReportParameter2Choice_
    #endif
    {
    }
}
