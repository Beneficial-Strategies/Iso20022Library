// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the Know Your Customer (KYC) check type.
    /// </summary>
    [KnownType(typeof(KYCCheckType1Choice.Code))]
    [KnownType(typeof(KYCCheckType1Choice.Proprietary))]
    [JsonDerivedType(typeof(KYCCheckType1Choice.Code),nameof(KYCCheckType1Choice.Code))]
    [JsonDerivedType(typeof(KYCCheckType1Choice.Proprietary),nameof(KYCCheckType1Choice.Proprietary))]
    [IsoId("_HadL0RRxEeOKWo1NF21OVw")]
    [DisplayName("KYC Check Type 1 Choice")]
    public abstract partial record KYCCheckType1Choice_
    {
    }
}
