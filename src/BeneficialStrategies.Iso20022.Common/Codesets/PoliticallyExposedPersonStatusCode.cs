// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Status of a politically exposed person.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_rmRbMJUiEemC09f0MxYkRg")]
[Description(@"Status of a politically exposed person.")]
[Derivations(typeof(PoliticallyExposedPersonStatus1Code))]
public enum PoliticallyExposedPersonStatusCode
{
    /// <summary>
    /// Natural person who is or who has been entrusted with prominent public functions.
    /// Encoded/decoded by serializers as &quot;PE01&quot;.
    /// </summary>
    [EnumMember(Value = "PE01")]
    [IsoId("_id8EEJUqEemC09f0MxYkRg")]
    [Description(@"Natural person who is or who has been entrusted with prominent public functions.")]
    NaturalPersonEntrusted,
    
    /// <summary>
    /// Family member of the politically exposed person. A family member includes: 
    /// (a) the spouse, or a person considered to be equivalent to a spouse, of the politically exposed person,
    /// (b) the children and their spouses, or persons considered to be equivalent to a spouse, of the politically exposed person,
    /// (c) the parents of the politically exposed person.
    /// Encoded/decoded by serializers as &quot;PE02&quot;.
    /// </summary>
    [EnumMember(Value = "PE02")]
    [IsoId("_ihzQYJUqEemC09f0MxYkRg")]
    [Description(@"Family member of the politically exposed person. A family member includes: |(a) the spouse, or a person considered to be equivalent to a spouse, of the politically exposed person,|(b) the children and their spouses, or persons considered to be equivalent to a spouse, of the politically exposed person,|(c) the parents of the politically exposed person.")]
    FamilyMember,
    
    /// <summary>
    /// Person known to be a close associate of the politically exposed person. A person known to be a close associate includes: 
    /// (a) a natural person who is known to have joint beneficial ownership of legal entities or legal arrangements, or any other close business relations, with the  politically exposed person,
    /// (b) a natural person who has sole beneficial ownership of a legal entity or legal arrangement which is known to have been set up for the de facto benefit of a politically exposed person.
    /// Encoded/decoded by serializers as &quot;PE03&quot;.
    /// </summary>
    [EnumMember(Value = "PE03")]
    [IsoId("_isqckJUqEemC09f0MxYkRg")]
    [Description(@"Person known to be a close associate of the politically exposed person. A person known to be a close associate includes: |(a) a natural person who is known to have joint beneficial ownership of legal entities or legal arrangements, or any other close business relations, with the  politically exposed person,|(b) a natural person who has sole beneficial ownership of a legal entity or legal arrangement which is known to have been set up for the de facto benefit of a politically exposed person.")]
    CloseAssociate,
    
}
