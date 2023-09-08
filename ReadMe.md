# EventDriven.SchemaValidator.Json

A JSON implementation of ISchemaValidator in EventDriven.SchemaRegistry.Abstractions.

## Introduction

**EventDriven.SchemaValidator.Json** provides a JSON implementation of ISchemaValidator EventDriven.SchemaRegistry.Abstractions to support event driven architectures.

## Version 2

Starting with version 2, this library uses NJsonSchema instead of Newtonsoft.Json.Schema, which has an MIT license.

As before, camel casing is used for schema generation, and additional object properties are always allowed.

Data annotations should be used on models for generating schemas with specific rules, such as required fields or numeric ranges.