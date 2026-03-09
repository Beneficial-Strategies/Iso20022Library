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
    /// Choice between a code or a proprietary code for the underlying master agreement.
    /// </summary>
    [KnownType(typeof(AgreementFramework1Choice.AgreementFramework))]
    [KnownType(typeof(AgreementFramework1Choice.ProprietaryIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AgreementFramework1Choice.AgreementFramework),nameof(AgreementFramework1Choice.AgreementFramework))]
    [JsonDerivedType(typeof(AgreementFramework1Choice.ProprietaryIdentification),nameof(AgreementFramework1Choice.ProprietaryIdentification))]
    #endif
    [IsoId("_UkZWTNp-Ed-ak6NoX_4Aeg_863321778")]
    [DisplayName("Agreement Framework 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AgreementFramework1Choice_
    #else
    public abstract partial class AgreementFramework1Choice_
    #endif
    {
    }
}
