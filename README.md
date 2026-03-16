# APBD Git assignment

Repository for Git and GitHub exercises.


## Rebase note

This repository contains an example of rebasing a feature branch onto an updated main branch.


## Answers

### 1. When does Git perform a fast-forward merge, and when is a merge commit created?
Git performs a fast-forward merge when the target branch has no new commits after the feature branch was created, so Git can simply move the branch pointer forward. A merge commit is created when both branches have diverged and Git must combine two different lines of history.

### 2. What is the practical difference between merge and rebase?
Merge preserves the real branch structure and history, usually by creating a merge commit. Rebase rewrites commits so that a branch appears to start from the newest version of the base branch, which creates a cleaner and more linear history.

### 3. How was the conflict resolved in this repository?
The conflict was created by changing the same input prompt differently in the `main` branch and the `feature-conflict` branch. It was resolved manually by editing `Program.cs`, choosing one final version of the prompt, removing the conflict markers, and then committing the resolved file.