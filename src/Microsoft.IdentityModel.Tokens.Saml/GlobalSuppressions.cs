﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible", Justification = "Breaking change", Scope = "member", Target = "~F:Microsoft.IdentityModel.Tokens.Saml2.Saml2Constants.AcceptedDateTimeFormats")]
[assembly: SuppressMessage("Usage", "CA2211:Non-constant fields should not be visible", Justification = "Breaking change", Scope = "member", Target = "~F:Microsoft.IdentityModel.Tokens.Saml.SamlConstants.AcceptedDateTimeFormats")]
[assembly: SuppressMessage("Design", "CA1034:Nested types should not be visible", Justification = "Breaking change", Scope = "type", Target = "~T:Microsoft.IdentityModel.Tokens.Saml2.Saml2Constants")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "New object takes ownership", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml2.Saml2SecurityTokenHandler.CanReadToken(System.String)~System.Boolean")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "New object takes ownership", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml.SamlSecurityTokenHandler.CanReadToken(System.String)~System.Boolean")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Doesn't own object", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml.SamlSerializer.ReadAssertion(System.Xml.XmlReader)~Microsoft.IdentityModel.Tokens.Saml.SamlAssertion")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Doesn't own disposable", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml2.Saml2Serializer.ReadAssertion(System.Xml.XmlReader)~Microsoft.IdentityModel.Tokens.Saml2.Saml2Assertion")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Doesn't own disposable", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml.SamlSerializer.WriteAssertion(System.Xml.XmlWriter,Microsoft.IdentityModel.Tokens.Saml.SamlAssertion)")]
[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "Doesn't own disposable", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml2.Saml2Serializer.WriteAssertion(System.Xml.XmlWriter,Microsoft.IdentityModel.Tokens.Saml2.Saml2Assertion)")]
[assembly: SuppressMessage("Design", "CA1034:Nested types should not be visible", Justification = "Breaking change", Scope = "type", Target = "~T:Microsoft.IdentityModel.Tokens.Saml.SamlConstants")]
[assembly: SuppressMessage("Design", "CA1034:Nested types should not be visible", Justification = "Breaking change", Scope = "type", Target = "~T:Microsoft.IdentityModel.Tokens.Saml.SamlAttributeKeyComparer.AttributeKey")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.Saml2.Saml2Assertion.Version")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.Saml.SamlAssertion.MinorVersion")]
[assembly: SuppressMessage("Performance", "CA1822:Mark members as static", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.Saml.SamlAssertion.MajorVersion")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Validation is mostly done in utility method", Scope = "type", Target = "~T:Microsoft.IdentityModel.Tokens.Saml2.Saml2Serializer")]
[assembly: SuppressMessage("Design", "CA1062:Validate arguments of public methods", Justification = "Validation is mostly done in utility method", Scope = "type", Target = "~T:Microsoft.IdentityModel.Tokens.Saml.SamlSerializer")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Breaking change", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml.SamlSecurityTokenHandler.CanReadToken(System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Breaking change", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml2.Saml2SecurityTokenHandler.CanReadToken(System.String)~System.Boolean")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is returned as string", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml2.Saml2SecurityTokenHandler.ValidateSignature(Microsoft.IdentityModel.Tokens.Saml2.Saml2SecurityToken,System.String,Microsoft.IdentityModel.Tokens.TokenValidationParameters)~Microsoft.IdentityModel.Tokens.Saml2.Saml2SecurityToken")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Exception is returned as string", Scope = "member", Target = "~M:Microsoft.IdentityModel.Tokens.Saml.SamlSecurityTokenHandler.ValidateSignature(Microsoft.IdentityModel.Tokens.Saml.SamlSecurityToken,System.String,Microsoft.IdentityModel.Tokens.TokenValidationParameters)~Microsoft.IdentityModel.Tokens.Saml.SamlSecurityToken")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.Saml.SamlAssertion.CanonicalString")]
[assembly: SuppressMessage("Design", "CA1031:Do not catch general exception types", Justification = "Breaking change", Scope = "member", Target = "~P:Microsoft.IdentityModel.Tokens.Saml2.Saml2Assertion.CanonicalString")]
