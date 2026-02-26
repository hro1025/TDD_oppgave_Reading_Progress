# Reading Progress Tracker — TDD Exercise
Overview

This exercise explores Test-Driven Development (TDD) by building a small, isolated domain model step by step.
The focus is not on completeness, but on learning how design emerges through tests.

Assignment

Title: Exploring a Domain with TDD — Reading Progress Tracker
Time frame: 1–2 hours
Focus: Red → Green → Refactor as a learning cycle
Goal: Experience how design evolves through tests

Background

You will build a small, isolated part of a system that tracks how far you have progressed in a book.

The scope is intentionally limited:

No UI

No database

Pure domain logic only

## Part 1 — Formulate the Hypothesis

Create a class called ReadingProgress that can answer the question:

“How far along am I in this book?”

The design is intentionally vague.
You begin by writing tests.

## Part 2 — First Experiment (Red)

Hypothesis:
If 0 pages of a book have been read, the progress should be 0%.

Write one test that expresses this behavior

The test should fail

Part 3 — Minimal Implementation (Green)

Implement just enough code to make the test pass.

Do not add extra functionality

Focus only on satisfying the test

## Part 4 — Refactor

Refactor the code for clarity without changing behavior.

Tests must remain green

## Part 5 — New Hypothesis

Hypothesis:
If half of the book has been read, the progress should be 50%.

Repeat the Red → Green → Refactor cycle.

## Part 6 — Edge Case Exploration

Choose one of the following scenarios:

Total pages = 0

Pages read > total pages

Pages read < 0

Write the test first, then decide how the system should behave.