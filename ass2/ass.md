# Deployment Activity 2

You should perform tasks that will, in total, provide a potential of 10 marks.

> **Submit your Task 2 AWS cloud platform deployment report only.**  
> Don't submit other task reports here.

## Task 2. Deployment to the AWS Cloud Platform — Individual Task

> **Note:** Tasks 2.2 and beyond require access to the AWS documentation and require an AWS account. You may be required to provide credit card details and may be charged for some AWS resources.

### Task 2.1 — Pass

_(If completed fully with the highest quality)_

By following AWS documentation on the links provided, complete the following tasks:

- Open an AWS account  
  https://docs.aws.amazon.com/codedeploy/latest/userguide/getting-started-setting-up.html

- Create an SSH key pair  
  https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-key-pairs.html

- Create an EC2 instance  
  https://docs.aws.amazon.com/codedeploy/latest/userguide/instances-ec2-create.html

- Deploy a WordPress instance to it  
  https://docs.aws.amazon.com/codedeploy/latest/userguide/tutorials-wordpress-launch-instance.html

### Task 2.2 — Credit

_(If completed fully with the highest quality)_

By following AWS documentation:

- Complete Task 2.1
- Create an ELB
- Re-install WordPress using an external database
  - Copy the existing WordPress database to an RDS instance and use it instead of the database on the EC2 instance.
- Backup instance to S3
- Create an instance from S3 backup

### Task 2.3 — Distinction

- Complete Task 2.2
- Create a **Launch Template**  
  _(formerly Launch Configuration, now deprecated)_
- Create an **ASG**
- Configure ASG to launch an instance
- Test scaling

### Task 2.4 — High Distinction

- Complete Task 2.3
- Set up and demonstrate SSH access from Windows or Mac
- Demonstrate, using screenshots, various command-line interactions with the instance

---

## General Task Requirements

Each task has a marking rubric that includes the minimum requirements needed to achieve the equivalent of Pass, Credit, Distinction, or HD grades.

In general, the mark achieved for a task will be determined by:

- The sub-tasks attempted
- The quality of the completed tasks

To attempt a high grade for a task, students must complete **all lower-level sub-tasks** leading up to that level.

Students may choose to attempt high grades for some small tasks but only a pass grade for larger tasks.

The final result for the portfolio will be the sum of the grades for each task.

Submit a report including:

- What you did
- Screenshots providing evidence of completion

The report must include a **publicly accessible IP address/URL** for verification.

Submit the report through the **Canvas Assignment portal**.

> Please submit before the due date. Any late submissions (up to 5 days) will incur a penalty as stipulated in the unit outline.

---

# Submission Instructions

## Deployment Report

For each deployment task, prepare a **PDF or RTF document** with the following sections:

1. **Student details**
   - Student ID
   - Full name

2. **Unit details**
   - Unit code and name: **SWE40006 Software Deployment and Evolution**
   - Semester

3. **Due date and submission date**
   - Due date (for feedback)
   - Submission date

4. **Declaration of the task level attempted**
   - Sub-tasks 2.1 to 2.4

5. **Evidence of completion**

   Provide evidence of completion of the various sub-tasks. Evidence can include:
   - Screenshots with captions
   - Pasted text from console windows
   - Description of what you did
   - Description of any errors or unresolved problems

   ### Notes
   - Where source code and/or script files are required for discussion/verification, include them through the **publicly accessible IP address / URL**.
   - **Do not include source code or scripts directly in the report.**
   - Binaries (executables) should not be submitted.
   - Evidence of successful compiling/building/deployment should instead be included as screenshots or pasted console output.
   - Each report must be submitted through the **Canvas Submission portal** before the due date.

---

## Important Submission Conditions

The submitted report will receive feedback and grades **only once**. There are no re-submissions/re-assessments.

> **Important:** If you are aiming for a particular level (C/P/D/HD) in a task, you have to work on that level. You cannot change to another level after the due date.

Feedback will be given based on the level you are aiming for when you first submit the work by the due date.

# Deployment 2 Rubric

## 1. Analysing and Investigating — 4 pts

| Rating               |    Points | Criteria                                                                                               |
| -------------------- | --------: | ------------------------------------------------------------------------------------------------------ |
| **High Distinction** | **4 pts** | Analysed and investigated errors on the AWS console and described clearly how to eradicate all errors. |
| **Distinction**      | **3 pts** | Analysed and investigated errors on the AWS console and provided a short brief on eradicating errors.  |
| **Credit**           | **2 pts** | Analysed and investigated errors on the AWS console but did not provide enough explanations.           |
| **Pass**             |  **1 pt** | Analysed a few errors but did not investigate errors on the AWS console.                               |
| **No marks**         | **0 pts** | No evidence provided for the criterion.                                                                |

---

## 2. Source Coding and Brief Explanation — 4 pts

| Rating               |    Points | Criteria                                                                                                                                                                                                    |
| -------------------- | --------: | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **High Distinction** | **4 pts** | Demonstrated the ability to provide deployment outcomes successfully with a brief explanation of coding/scripts and screenshots demonstrating various command-line interactions with the instances.         |
| **Distinction**      | **3 pts** | Demonstrated the ability to provide deployment outcomes successfully with coding/scripts, configuring ASG to launch instances, and testing scaling, with screenshots from AWS.                              |
| **Credit**           | **2 pts** | Demonstrated the ability to provide deployment outcomes successfully with 1–2 errors in coding/scripts, backing up instances to S3, and creating an instance from the S3 backup, with screenshots from AWS. |
| **Pass**             |  **1 pt** | Demonstrated the ability to provide deployment outcomes with few errors in coding/scripts on the AWS console, with screenshots from AWS.                                                                    |
| **No marks**         | **0 pts** | No evidence provided for the criterion.                                                                                                                                                                     |

---

## 3. Quality, Report Writing Skills, Spelling and Grammar — 1 pt

| Rating               |       Points | Criteria                                                                                          |
| -------------------- | -----------: | ------------------------------------------------------------------------------------------------- |
| **High Distinction** |     **1 pt** | Written report with no spelling or grammar errors throughout the text and better-quality content. |
| **Distinction**      | **0.75 pts** | Written report with no spelling or grammar errors throughout the text with good-quality content.  |
| **Credit**           |  **0.5 pts** | Written report with minor spelling and grammar errors throughout the text.                        |
| **Pass**             | **0.25 pts** | Written report with major spelling and grammar errors throughout the text.                        |
| **No marks**         |    **0 pts** | No evidence provided for the criterion.                                                           |

---

## 4. Quality in Report Structure — 1 pt

### Appropriate Headings/Sub-headings

| Rating               |       Points | Criteria                                                                            |
| -------------------- | -----------: | ----------------------------------------------------------------------------------- |
| **High Distinction** |     **1 pt** | Ability to provide report structure in an appropriate form and proper explanations. |
| **Distinction**      | **0.75 pts** | Ability to provide report structure in an appropriate form with few explanations.   |
| **Credit**           |  **0.5 pts** | Ability to provide report structure in an appropriate form.                         |
| **Pass**             | **0.25 pts** | Does not have the ability to provide report structure in an appropriate form.       |
| **No marks**         |    **0 pts** | No evidence provided for the criterion.                                             |

---

# Total: 10 Points

| Criterion                                            | Maximum Points |
| ---------------------------------------------------- | -------------: |
| Analysing and Investigating                          |              4 |
| Source Coding and Brief Explanation                  |              4 |
| Quality, Report Writing Skills, Spelling and Grammar |              1 |
| Quality in Report Structure                          |              1 |
| **Total**                                            |         **10** |
