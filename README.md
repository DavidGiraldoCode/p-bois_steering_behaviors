# Interactive authoring of boids for video games using Radial Basis Functions (RBF)

<aside>
🚧 I am currently working on my final project for the course DH2323 Computer Graphics and Interaction at KTH Royal Institute of Technology.

</aside>

How do we interpolate when there is no grid? Having no sample grid is a scattered data problem for which traditional linear interpolation does not suffice. Thus, Radial Basis Functions exist as a solution for this problem by defining a function capable of interpolating any given discrete value in space, given all the values at source points.

$$
S(\mathbf{x}) = \sum_{i=1}^{n} \lambda_i \phi(||\mathbf{x} - \mathbf{x}_i||), \quad \mathbf{x} \in \mathbb{R}^d.

$$

$$
\Phi(r) = ||\mathbf{x} - \mathbf{x}_i||
$$

Jin (2009) presented an application of crow authoring relaying on path-planning components. They incorporated radial basis function interpolation of vector fields to guide pedestrians' flow in a grid-less setup.

I am implementing and applying their paper to author the flow of a flock of boids.

## Updates

## Next steps

- [ ]  Control 1 boid in 3D with the vector field in 2D
    - [ ]  Place the VF on the ground under the flying area (using x,z instead of x,y)
    - [ ]  Use the X and Z coordinates to sample a point in the vector field.
    - [ ]  Interpolate the vector components with the RBFs
    - [ ]  Apply the force of the field on the boid’s behavior

## More about crowd simulations

Representing multiple living entities in a virtual world has been one task that entices computer graphics practitioners, from movies and video games to urban planning and architecture. This is a branch of computer graphics animation called crow simulation. Crowd simulation is about representing non-verbal behaviors of virtual agents and their relations with their environment and others, characterized by the change of position of entities over time (Colas 2022). 

Lemonari (2022) categorizes the components that encompass crowd simulation and the aspects that can be authored into six categories: Hih-level behaviors, path-planning, local movements, bony animation, visualization, and post-processing.

## References

- Colas, A., van Toll, W., Zibrek, K., Hoyet, L., Olivier, A.-.-H. and Pettré, J. (2022), Interaction Fields: Intuitive Sketch-based Steering Behaviors for Crowd Simulation. Computer Graphics Forum, 41: 521-534. https://doi.org/10.1111/cgf.14491
- Jin, Xiaogang & Xu, Jiayi & Wang, Charlie & Huang, Shengsheng & Zhang, Jun. (2009). Interactive Control of Large-Crowd Navigation in Virtual Environments Using Vector Fields. IEEE computer graphics and applications. 28. 37-46. 10.1109/MCG.2008.117.
- Lemonari, M., Blanco, R., Charalambous, P., Pelechano, N., Avraamides, M., Pettré, J. and Chrysanthou, Y. (2022), Authoring Virtual Crowds: A Survey. Computer Graphics Forum, 41: 677-701. https://doi.org/10.1111/cgf.14506
- Reynolds, C. W. (1987). Flocks, herds and schools: A distributed behavioral model. SIGGRAPH Comput. Graph. 21, 4 (July 1987), 25–34. https://doi.org/10.1145/37402.37406
- Reynolds, C. W. (1999). Steering Behaviors For Autonomous Characters. Sony Computer Entertainment America, 919 East Hillsdale Boulevard, Foster City, California 94404. Retrieved from http://www.red.com/cwr/
