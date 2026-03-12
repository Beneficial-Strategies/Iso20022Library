// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of Common Reporting Standard (CRS) form.
    /// </summary>
    [KnownType(typeof(CRSForm1Choice.Code))]
    [KnownType(typeof(CRSForm1Choice.Proprietary))]
    [JsonDerivedType(typeof(CRSForm1Choice.Code),nameof(CRSForm1Choice.Code))]
    [JsonDerivedType(typeof(CRSForm1Choice.Proprietary),nameof(CRSForm1Choice.Proprietary))]
    [IsoId("_fscaYUNuEeaS-NnwLNvMPg")]
    [DisplayName("CRS Form 1 Choice")]
    public abstract partial record CRSForm1Choice_
    {
    }
}
