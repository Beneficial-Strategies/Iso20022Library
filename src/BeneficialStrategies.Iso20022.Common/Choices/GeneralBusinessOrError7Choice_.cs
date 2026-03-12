// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// It is used to provide some or all of the members with information related to the processing of the system.
    /// </summary>
    [KnownType(typeof(GeneralBusinessOrError7Choice.OperationalError))]
    [KnownType(typeof(GeneralBusinessOrError7Choice.BusinessReport))]
    [JsonDerivedType(typeof(GeneralBusinessOrError7Choice.OperationalError),nameof(GeneralBusinessOrError7Choice.OperationalError))]
    [JsonDerivedType(typeof(GeneralBusinessOrError7Choice.BusinessReport),nameof(GeneralBusinessOrError7Choice.BusinessReport))]
    [IsoId("_QOIUkXhdEeidzqjNEfehPg")]
    [DisplayName("General Business Or Error 7 Choice")]
    public abstract partial record GeneralBusinessOrError7Choice_
    {
    }
}
